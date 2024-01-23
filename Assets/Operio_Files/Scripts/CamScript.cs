using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    Vector3 planet, spaceship;
    public float SmoothSpeed;
    public Vector3 Offset;

    private void Start()
    {
        planet = GameObject.FindGameObjectWithTag("Planet").transform.position;
    }
    private void FixedUpdate()
    {
        Vector3 DesiredPosition = planet - Offset;
        Vector3 smoothposition = Vector3.Lerp(transform.position, DesiredPosition, SmoothSpeed * Time.deltaTime);
        transform.position = smoothposition;
    }
}
