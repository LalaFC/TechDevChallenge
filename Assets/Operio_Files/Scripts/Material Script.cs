using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialScript : MonoBehaviour
{
    private MeshRenderer Mesh;
    private bool startTimer=false;
    [SerializeField] float Timer;
    // Start is called before the first frame update
    void Awake()
    {
        Mesh = GetComponentInChildren<MeshRenderer>();
        Mesh.enabled= false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Planet")
        {
            Mesh.enabled = true;
            startTimer = true;
        }

    }
    private void FixedUpdate()
    {
        if (startTimer) 
        {
            Timer += Time.deltaTime;
        }
        if (Timer >= 5)
            Destroy(this.gameObject);
    }


}
