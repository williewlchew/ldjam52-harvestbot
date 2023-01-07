using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTileCollider : MonoBehaviour
{
    public SpriteRenderer _spriteRenderer;
    private bool selected;

    public Color selectedColor = new Color (1, 1, 1, 0.5f);
    public Color unselectedColor = new Color (1, 1, 1, 0.1f);

    void Start()
    {
        _spriteRenderer.color = unselectedColor;
    }

    /* PHYSICS */

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            selected = true;
            ViewSelected();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            selected = false;
            UnviewSelected();
        }
    }

    /* VISUALS */

    private void ViewSelected()
    {
        StartCoroutine(ChangeColorRoutine(unselectedColor, selectedColor, true));
    }

    private void UnviewSelected()
    {
        StartCoroutine(ChangeColorRoutine(selectedColor, unselectedColor, false));
    }

    IEnumerator ChangeColorRoutine(Color c1, Color c2, bool isSelected){
        float ElapsedTime = 0.0f;
        float TotalTime = 0.25f;
        while (ElapsedTime < TotalTime & (selected == isSelected)) {
            ElapsedTime += Time.deltaTime;
            _spriteRenderer.color = Color.Lerp(c1, c2, (ElapsedTime / TotalTime));
            yield return null;
        }
    }
}
