using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    public string MessageText;
    public TextBubble textBubble;
    public GameObject textBubbleObject;

    void OnTriggerEnter (Collider other)
    {
        textBubble.DisplayMessage(MessageText);
        textBubbleObject.SetActive(true);
    }

    void OnTriggerExit (Collider other)
    {
        textBubbleObject.SetActive(false);
        Destroy(this.gameObject);
    }
}
