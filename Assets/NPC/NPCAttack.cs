using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAttack : MonoBehaviour
{
    public NPCManager _bearManager;
    public float attackWait = 1f;
    private bool inProximity = false;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            inProximity = true;
            _bearManager.attacking = true;
            _bearManager.agent.isStopped = true;
            StartCoroutine(AttackRoutine(other.gameObject.transform.position, attackWait));
            _bearManager._animator.SetInteger("CurrentAnimation", 20);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            inProximity = false;
            _bearManager.attacking = false;
            _bearManager.agent.isStopped = false;
            _bearManager._animator.SetInteger("CurrentAnimation", 0);
        }
    }

    IEnumerator AttackRoutine(Vector3 target, float seconds)
    {
        yield return new WaitForSeconds(seconds);
        if (inProximity == true){
            _bearManager.Attack(target);
        }
    }
}
