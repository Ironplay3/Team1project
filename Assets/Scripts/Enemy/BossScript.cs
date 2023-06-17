using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossScript : MonoBehaviour
{
    [SerializeField] NavMeshAgent navAgent;
    [SerializeField] Animator animator;
    private Transform player;
    private Vector3 startPosition;
    [SerializeField] GameObject health;

    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        startPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {


        if (Vector3.Distance(transform.position, player.position) <= 30)
        {
            navAgent.destination = player.transform.position;
            if (Vector3.Distance(transform.position, player.position) <= 5)
            {
                animator.SetBool("isAttacking", true);
                health.SetActive(true);
            }
            else
            {
                animator.SetBool("isAttacking", false);
                animator.SetBool("isWalking", true);
              
            }
        }
        else
        {
            navAgent.destination = startPosition;


        }
        if (navAgent.destination == startPosition)
        {
            animator.SetBool("isWalking", false);

        }
    }
}
