using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject UISeeds;
    public GameObject UIHoeTool;
    public GameObject UIWateringCan;
    public GameObject UIOnion;
    public GameObject UIPotato;
    public GameObject UICarrot;
    public GameObject UIStart;
    public GameObject UIVictory;
    public ItemPickupAudio itemPickupAudio;
    public AudioSource audio;
    public AudioClip MusicChaCha;

    public void PickupItem(string item)
    {
        if(item == "Seeds") {
            PickupSeeds();
        } else if(item == "Rake") {
            PickupHoeTool();
        } else if(item == "WaterCan") {
            PickupWateringCan();
        } else if(item == "Onion") {
            PickupOnion();
        } else if(item == "Potato") {
            PickupPotato();
        } else if(item == "Carrot") {
            PickupCarrot();
        }
    }

    public void PickupSeeds()
    {
        itemPickupAudio.PlayItemPickupSound();
        UISeeds.SetActive(true);
    }

    public void PickupHoeTool()
    {
        itemPickupAudio.PlayItemPickupSound();
        UIHoeTool.SetActive(true);
    }

    public void PickupWateringCan()
    {
        itemPickupAudio.PlayItemPickupSound();
        UIWateringCan.SetActive(true);
    }

    public void PickupOnion()
    {
        itemPickupAudio.PlayItemPickupSound();
        UIOnion.SetActive(true);
    }

    public void PickupPotato()
    {
        itemPickupAudio.PlayItemPickupSound();
        UIPotato.SetActive(true);
    }

    public void PickupCarrot()
    {
        itemPickupAudio.PlayItemPickupSound();
        UICarrot.SetActive(true);
    }

    public void VictoryScreen()
    {
        UIVictory.SetActive(true);
        audio.Stop();
    }

    public void Play()
    {
        Debug.Log("CLICK");
        UIStart.SetActive(false);
        UIVictory.SetActive(false);
        // Player.SetActive(true);
        audio.clip = MusicChaCha;
        audio.Play();
    }

    public void Pause()
    {
        // Player.SetActive(false);
        UISeeds.SetActive(false);
        UIHoeTool.SetActive(false);
        UIWateringCan.SetActive(false);
        UIOnion.SetActive(false);
        UIPotato.SetActive(false);
        UICarrot.SetActive(false);
        UIStart.SetActive(true);
        UIVictory.SetActive(false);
        audio.Stop();
    }

    void Awake()
    {
        // Debug.Log(SceneManager.GetActiveScene().name);
        if(SceneManager.GetActiveScene().name == "MainMenu") {
            Pause();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Pause();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
