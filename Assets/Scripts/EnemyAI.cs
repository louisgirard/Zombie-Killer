using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] float chaseRange = 10f;
    [SerializeField] Transform target;
    NavMeshAgent navMeshAgent;
    Animator animator;

    float distanceToTarget;
    bool isProvoked = false;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceToTarget = Vector3.Distance(transform.position, target.position);

        if (isProvoked)
        {
            EngageTarget();
        }
        else if (distanceToTarget <= chaseRange)
        {
            isProvoked = true;
        }
    }

    private void EngageTarget()
    {
        if(distanceToTarget >= navMeshAgent.stoppingDistance)
        {
            ChaseTarget();
        }
        else
        {
            animator.SetBool("attack", true);
        }
    }

    private void ChaseTarget()
    {
        animator.SetBool("attack", false);
        animator.SetTrigger("move");
        navMeshAgent.SetDestination(target.position);
    }

    void OnDrawGizmosSelected()
    {
        // Display the explosion radius when selected
        Gizmos.color = new Color(1, 1, 0, 0.75f);
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
