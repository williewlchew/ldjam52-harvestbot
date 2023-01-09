using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    public string MessageText;
    public GameObject Self;
    public TextBubble textBubble;
    // public PlayerController player;
    void OnTriggerEnter (Collider other)
    {
        textBubble.DisplayMessage(MessageText);
        Self.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        Self.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
