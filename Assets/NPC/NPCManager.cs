using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public Animator _animator;
    public Transform[] patrolPoints2;

    public bool attacking;

    public int currentPhase = 0;
    private int currentPatrol2Point;
    public UnityEngine.AI.NavMeshAgent agent;

    void Start() 
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        _animator.SetInteger("CurrentAnimation", 0);

        // nav
        agent.isStopped = true;
    }

    void Update () 
    { 
        // moving
        if(AtCurrentGoal(patrolPoints2[currentPatrol2Point].position)){
            currentPatrol2Point += 1;
            if(currentPatrol2Point == patrolPoints2.Length && !attacking){
                currentPatrol2Point = 0;
            }
        }
        agent.destination = patrolPoints2[currentPatrol2Point].position;

        // visual
        if(!attacking){
            agent.isStopped = false;
            AnimateMovement(patrolPoints2[currentPatrol2Point].position);
        }
    }

    /* Attack */
    public void Attack(Vector3 target)
    {
        _animator.SetInteger("CurrentAnimation", 21);
        StartCoroutine(AttackRoutine(target));
        attacking = false;
        agent.isStopped = false;
        _animator.SetInteger("CurrentAnimation", 0);
    }

    IEnumerator AttackRoutine(Vector3 target)
    {
        while (!AtCurrentGoal(target)) {
            transform.position = Vector3.MoveTowards(transform.position, target, 10 * Time.deltaTime);
            yield return null;
        }
    }


    /* Navagation */
    private bool AtCurrentGoal(Vector3 goal)
    {
        float dist = Vector3.Distance(goal, transform.position);
        if(dist < 2f)
        {
            return true;
        }
        else {
            return false;
        }
    }

    /* Visuals */
    private void AnimateMovement(Vector3 target){
        if(target.z > transform.position.z){
            _animator.SetInteger("CurrentAnimation", 2);
        }
        else{
            _animator.SetInteger("CurrentAnimation", 1);
        }
    }
}
