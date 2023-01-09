using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchObject : MonoBehaviour
{
    public GameObject collider;
    public GameObject spriteRenderer;

    public void EnableObject()
    {
        collider.SetActive(true);
        spriteRenderer.SetActive(true);
    }

    public void DisableObject()
    {
        collider.SetActive(false);
        spriteRenderer.SetActive(false);
    }
}
