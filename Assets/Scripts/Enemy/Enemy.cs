using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] int weaponDamage;
    [SerializeField] float weaponRange;
    [SerializeField] Transform rayOrigin;
    [SerializeField] NavMeshAgent navAgent;
    [SerializeField] Animator animator;
    
    private Transform player;
    private Vector3 startPosition;

    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        startPosition = transform.position;

    }
    public void Hit()
    {
        RaycastHit HitInfo;

        if (Physics.Raycast(rayOrigin.position, rayOrigin.forward, out HitInfo, weaponRange))
        {
            if (HitInfo.transform.gameObject.GetComponent<Health1>())
                HitInfo.transform.gameObject.GetComponent<Health1>().GetDamage(weaponDamage);
        }
    }
    // Update is called once per frame
    void Update()
    {


        if (Vector3.Distance(transform.position, player.position) <= 10)
        {
            navAgent.destination = player.transform.position;
            if (Vector3.Distance(transform.position, player.position) <= 3)
            {
                animator.SetBool("isAttacking", true);
                navAgent.stoppingDistance = 2;
                
            }
            else
            {
                animator.SetBool("isAttacking", false);
                animator.SetBool("isWalking", true);
                navAgent.stoppingDistance = 0;
                
            }
        }
        else
        {
            navAgent.destination = startPosition;
            if (Vector3.Distance(transform.position, startPosition) <= 0.5f)
            {
                animator.SetBool("isWalking", false);
               
            }

        }
       
    }
}
