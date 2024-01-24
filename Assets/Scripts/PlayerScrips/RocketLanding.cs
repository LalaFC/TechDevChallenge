using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RocketLanding : MonoBehaviour
{
    public GameObject Target;
    private float speed;

    public float fadeDuration = 1.0f;
    private float TimeCount;


    void Update()
    {
        TimeCount = Time.time;
        if (TimeCount < 2)
        {
            speed = 1;
        }

        else speed = 2;
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Planet")
        {
            DOTween.ToAlpha(() => Camera.main.backgroundColor, color => Camera.main.backgroundColor = color, 1f, fadeDuration).OnComplete(() =>
            {
            SceneManager.LoadScene(1);
            });

        }

    }
}
