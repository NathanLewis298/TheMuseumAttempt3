using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatorcontroller : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>(); 
    }

    
    void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("IsWalking", true);
        }

        if (!Input.GetKey("w"))
        {
            animator.SetBool("IsWalking", false);
        }


        if (Input.GetKey("s"))
        {
            animator.SetBool("IsWalkingBackwards", true);
        }

        if (!Input.GetKey("s"))
        {
            animator.SetBool("IsWalkingBackwards", false);
        }


        if (Input.GetKey("a"))
        {
            animator.SetBool("IsWalkingLeft", true);
        }

        if (!Input.GetKey("a"))
        {
            animator.SetBool("IsWalkingLeft", false);
        }

        if (Input.GetKey("d"))
        {
            animator.SetBool("IsWalkingRight", true);
        }

        if (!Input.GetKey("d"))
        {
            animator.SetBool("IsWalkingRight", false);
        }



    }
}
