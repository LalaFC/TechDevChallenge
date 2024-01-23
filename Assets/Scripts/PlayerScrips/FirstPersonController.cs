using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

[RequireComponent(typeof(GravityBody))]
public class FirstPersonController : MonoBehaviour
{

    // public vars
    public float mouseSensitivityX = 5;
    public float mouseSensitivityY = 1;
    float verticalLookRotation;
    Transform cameraTransform;

    GravityBody gravityBody;

    // System vars
    Rigidbody rigidbody;

    //new input system
    PlayerInputEditor playerInputEditor;

    //movement var
    Vector2 walkAction;
    Vector2 moveDirection;
    Vector3 movements;
    Vector3 moveAmount;
    Vector3 smoothVelocity;

    public float moveSpeed = 5f;

    private void OnEnable()
    {
        if (playerInputEditor == null)
        {
            playerInputEditor = new PlayerInputEditor();

            playerInputEditor.playerMovements.walk.performed += i => walkAction = i.ReadValue<Vector2>();
            playerInputEditor.playerMovements.walk.canceled += i => walkAction = Vector2.zero;
        }
        playerInputEditor.Enable();
    }

    private void OnDisable()
    {
        if (playerInputEditor != null)
        {
            playerInputEditor.playerMovements.walk.performed -= i => walkAction = i.ReadValue<Vector2>();
            playerInputEditor.playerMovements.walk.canceled -= i => walkAction = Vector2.zero;
        }
        playerInputEditor.Disable();
    }

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
        rigidbody = GetComponent<Rigidbody>();
        cameraTransform = Camera.main.transform;

        gravityBody = GetComponent<GravityBody>();
    }

    void Update()
    {
        handleWalk();

        // Look rotation:
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * mouseSensitivityX);
        verticalLookRotation += Input.GetAxis("Mouse Y") * mouseSensitivityY;
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -60, 60);
        cameraTransform.localEulerAngles = Vector3.left * verticalLookRotation;
    }

    public void handleWalk()
    {
        moveDirection = walkAction;

        Vector3 moveDir = new Vector3(moveDirection.x, 0, moveDirection.y).normalized;

        Vector3 targetMoveAmount = moveDir * moveSpeed;
        moveAmount = Vector3.SmoothDamp(moveAmount, targetMoveAmount, ref smoothVelocity, .15f);



        Vector3 localMove = transform.TransformDirection(moveAmount) * Time.fixedDeltaTime;
        rigidbody.MovePosition(rigidbody.position + localMove);
        ConstrainToPlanetSurface();
    }

    void ConstrainToPlanetSurface()
    {
        // Get the direction from the planet center to the player
        Vector3 gravityUp = (transform.position - gravityBody.planet.transform.position).normalized;

        // Get the rotation to align the player with the planet surface
        Quaternion targetRotation = Quaternion.FromToRotation(transform.up, gravityUp) * transform.rotation;

        // Apply the rotation smoothly
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 50f * Time.deltaTime);
    }
}
