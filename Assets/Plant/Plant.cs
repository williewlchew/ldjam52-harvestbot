using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    private int state;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        state = 0;
        //animator = GetComponent<Animator>();
        UpdateVisuals();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Action(List<string> items)
    {
        if(CheckItems(items)){
            if(state <= 4)
            {
                state += 1;
            }
            else{
                state = 0;
            }
            
        }
        else{
            Debug.Log("No Banana");
        }
        UpdateVisuals();
    }

    private bool CheckItems(List<string> items)
    {
        return items.Contains("Banana");
    }

    public void UpdateVisuals()
    {
        animator.SetInteger("PlantState", state);
        Debug.Log("Plant State: " + state);
    }
}
