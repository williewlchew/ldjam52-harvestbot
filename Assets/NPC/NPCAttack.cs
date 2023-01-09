using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    bool 

    trig enter
        wait for time
        if in prox, attack
    trig exit
        in prox false
        attacking = false
*/

public class NPCAttack : MonoBehaviour
{
    public NPCManager _bearManager;
    public float attackWait = 1f;
    private bool inProximity = false;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            inProximity = true;
            _bearManager.attacking = true;
            _bearManager.agent.isStopped = true;
            _bearManager._animator.SetFloat("CurrentAnimation", 3);

            StartCoroutine(AttackRoutine(other.gameObject, attackWait)); 
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            inProximity = false;
            _bearManager.attacking = false;
            _bearManager.agent.isStopped = false;
        }
    }

    IEnumerator AttackRoutine(GameObject target, float seconds)
    {
        for (float timer = 0.1f; timer < seconds; timer += 0.1f)
        {
            yield return new WaitForSeconds(.1f);
            if(!inProximity)
            {
               break;
            }
        }
        if(inProximity)
        {
            _bearManager.Attack(target.transform.position);
        }
    }
}
