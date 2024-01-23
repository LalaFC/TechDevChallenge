using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{


    void Update()
    {
        transform.Rotate(0.15f, 0.2f,0);
    }
}
