using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBubble : MonoBehaviour
{
    public SpriteRenderer bubble;
    public TextMeshPro textMesh;

    public void Setup(string text) {
        textMesh.SetText(text);
        textMesh.ForceMeshUpdate();
        Vector2 textBoxSize = textMesh.GetRenderedValues(false);
        Vector2 padding = new Vector2(1f, 1f);
        bubble.size = textBoxSize + padding;
    }
    // Start is called before the first frame update
    void Start()
    {
        Setup("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
