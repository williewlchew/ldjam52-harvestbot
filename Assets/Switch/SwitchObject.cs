using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchObject : MonoBehaviour
{
    public GameObject collider;
    public Animator animator;

    public void EnableObject()
    {
        collider.SetActive(true);
        animator.SetBool("Enabled", true);
    }

    public void DisableObject()
    {
        collider.SetActive(false);
        animator.SetBool("Enabled", false);
    }
}
