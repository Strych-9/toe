using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DemonAnimator : MonoBehaviour
{
    public Transform player;
    private Animator animator; 
    private bool jump = false;
    private bool punch = false;

    void Start()
    {
       
        animator = GetComponent<Animator>(); 
        
    }

    void Update()
    {
        
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            
            if (distanceToPlayer <= 3.5f)
            {
                jump = true;
                punch = true;
            }
            else
            {
                jump = false; 
                punch = false;
            }

            
            animator.SetBool("Jump", jump);
            animator.SetBool("Punch", punch);
            //Debug.Log(distanceToPlayer);

    }
    
}
