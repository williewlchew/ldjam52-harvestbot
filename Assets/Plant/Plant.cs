using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    private int state;
    public Animator animator;
    public GameObject reward;
    public Transform rewardLocation;
    public WaterAudio waterAudio;
    public ShovelAudio shovelAudio;

    // Start is called before the first frame update
    void Start()
    {
        state = 0;
        //animator = GetComponent<Animator>();
        UpdateVisuals();
    }

    public void Action(List<string> items)
    {
        if(CheckItems(items)){
            state += 1;
            if(state >= 3)
            {
                GetReward();
            }
        }
        UpdateVisuals();
    }

    private bool CheckItems(List<string> items)
    {
        switch (state) 
        {
            case 0:
                shovelAudio.PlayShovelSound();
                return items.Contains("Rake");
            case 1:
                waterAudio.PlayWaterSound();
                return items.Contains("WaterCan");
            case 2:
                return items.Contains("Seeds");
            default:
                return items.Contains("Banana");
        }
    }

    private void GetReward()
    {
        // fill in
        Debug.Log("You win");

        Instantiate(reward, rewardLocation.position, Quaternion.identity);
    }

    public void UpdateVisuals()
    {
        animator.SetInteger("PlantState", state);
        Debug.Log("Plant State: " + state);
    }
}
