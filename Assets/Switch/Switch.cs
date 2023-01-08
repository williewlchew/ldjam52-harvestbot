using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public SwitchPhase switchPhase1;
    public SwitchPhase switchPhase2;
    public SpriteRenderer _spriteRenderer;
    private bool phase1 = true;

    public void Start()
    {
        switchPhase1.EnablePhase();
        switchPhase2.DisablePhase();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            if(!phase1)
            {
                switchPhase1.EnablePhase();
                switchPhase2.DisablePhase();
                _spriteRenderer.flipX = phase1;
            }
            else
            {
                switchPhase2.EnablePhase();
                switchPhase1.DisablePhase();
                _spriteRenderer.flipX = phase1;
            }
            phase1 = !(phase1);
        }
    }

}
