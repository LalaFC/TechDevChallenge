using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class RocketLanding : MonoBehaviour
{
    public GameObject Target;
    private float speed;
    void Update()
    {
        speed = 1;
        Target = GameObject.FindGameObjectWithTag("Planet");
        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, speed * Time.deltaTime);
        LookRotation();

    }
    void LookRotation()
    {
        float rotspeed = 20;
        Vector3 relativePos = Target.transform.position - this.transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, rotspeed * Time.deltaTime);
    }
<<<<<<< Updated upstream
=======

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Planet")
        {
            SceneManager.LoadScene(1);
        }

    }
>>>>>>> Stashed changes
}
