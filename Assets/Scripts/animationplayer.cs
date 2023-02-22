using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationplayer : MonoBehaviour
{
    Animator animator;

    float vertical;
    float horizontal;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        if (vertical == 0) 
        { 
            animator.SetBool("Run",false);
           
        }
        if (vertical >= 0.01f) 
        {
            animator.SetBool("Run", true);
        }

        if (vertical <= -0.01f) 
        {
            animator.SetBool("Run", true);
        }
        //if (horizontal == 0)
        //{
        //    animator.SetBool("Run", false);

        //}
        //if (horizontal >= 0.01f)
        //{
        //    animator.SetBool("Run", true);
        //}

        //if (horizontal <= -0.01f)
        //{
        //    animator.SetBool("Run", true);
        //}

    }
}
