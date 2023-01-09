using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBubble : MonoBehaviour
{
    public GameObject container;
    public SpriteRenderer bubble;
    public TextMeshPro textMesh;
    public float messageTime = 5f;

    IEnumerator MessageTimer()
    {
        container.SetActive(true);
        yield return new WaitForSeconds(messageTime);
        container.SetActive(false);
    }
    public void DisplayMessage(string text) {
        container.SetActive(false);
        textMesh.SetText(text);
        container.SetActive(true);
        textMesh.ForceMeshUpdate();
        Vector2 textBoxSize = textMesh.GetRenderedValues(false);
        Vector2 padding = new Vector2(1f, 1f);
        bubble.size = textBoxSize + padding;
        StartCoroutine("MessageTimer");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) {
            Debug.Log("CLICK");
            DisplayMessage("Hello World");
        }
    }
}
