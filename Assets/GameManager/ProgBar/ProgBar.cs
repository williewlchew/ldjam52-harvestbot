using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgBar : MonoBehaviour
{
    public GameObject progBar;
    public Slider slider;
    // public Image fill;
    public float timer = 2.5f;
    private float startTime;
    private float currentTime;

    IEnumerator ProgTimer()
    {
        startTime = Time.time;
        currentTime = startTime;
        slider.value = 0f;
        progBar.SetActive(true);
        while ((currentTime - startTime) < timer) {
            currentTime = Time.time;
            slider.value = ((currentTime - startTime) / timer);
            yield return null;
        }
        progBar.SetActive(false);
        yield return null;
    }

    public void StartProgBar()
    {
        StartCoroutine("ProgTimer");
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
        //     StartProgBar();
        // }
    }
}
