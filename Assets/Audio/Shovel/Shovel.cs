using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shovel : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip shovel1;
    public AudioClip shovel2;
    public AudioClip shovel3;
    public AudioClip shovel4;
    private int randomNum;

    public void PlayShovelSound()
    {
        randomNum = Random.Range(1, 4);
        if (randomNum == 1) {
            audio.clip = shovel1;
        } else if (randomNum == 2) {
            audio.clip = shovel2;
        } else if (randomNum == 3) {
            audio.clip = shovel3;
        } else {
            audio.clip = shovel4;
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
        //     PlayShovelSound();
        // }
    }
}
