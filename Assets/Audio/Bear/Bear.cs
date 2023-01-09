using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip bear1;
    public AudioClip bear2;
    public AudioClip bear3;
    public AudioClip bear4;
    private int randomNum;

    public void PlayBearSound()
    {
        randomNum = Random.Range(1, 4);
        if (randomNum == 1) {
            audio.clip = bear1;
        } else if (randomNum == 2) {
            audio.clip = bear2;
        } else if (randomNum == 3) {
            audio.clip = bear3;
        } else {
            audio.clip = bear4;
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
        //     PlayBearSound();
        // }
    }
}
