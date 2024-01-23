using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimationScripts : MonoBehaviour
{
    public Animator animator;

    public void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void startWalkingAnimation()
    {
        animator.SetBool("isRunning", true);
    }

    public void stopWalkingAnimation()
    {
        animator.SetBool("isRunning", false);
    }
}
