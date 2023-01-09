using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip itemPickup;

    public void PlayItemPickupSound()
    {
        audio.clip = itemPickup;
        audio.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetMouseButtonDown(1)) {
        //     Debug.Log("CLICK");
        //     PlayItemPickupSound();
        // }
    }
}
