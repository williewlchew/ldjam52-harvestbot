using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fart : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip fart1;
    public AudioClip fart2;
    public AudioClip fart3;
    public AudioClip fart4;
    private int randomNum;

    public void PlayFartSound()
    {
        randomNum = Random.Range(1, 4);
        if (randomNum == 1) {
            audio.clip = fart1;
        } else if (randomNum == 2) {
            audio.clip = fart2;
        } else if (randomNum == 3) {
            audio.clip = fart3;
        } else {
            audio.clip = fart4;
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
        //     PlayFartSound();
        // }
    }
}
