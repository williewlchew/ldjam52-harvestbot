using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitchAudio : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip doorSwtich;

    public void PlayDoorSwitchSound()
    {
        audio.clip = doorSwtich;
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
        //     PlayDoorSwitchSound();
        // }
    }
}
