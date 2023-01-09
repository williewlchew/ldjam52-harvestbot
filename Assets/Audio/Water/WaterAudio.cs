using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterAudio : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip water1;
    public AudioClip water2;
    private int randomNum;

    public void PlayWaterSound()
    {
        randomNum = Random.Range(1, 2);
        if (randomNum == 1) {
            audio.clip = water1;
        } else {
            audio.clip = water2;
        }
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
        //     PlayWaterSound();
        // }
    }
}
