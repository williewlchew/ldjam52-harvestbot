using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    private int state;
    public GameObject reward;
    public Transform rewardLocation;
    public ShovelAudio shovelAudio;
    public WaterAudio waterAudio;

    public SpriteRenderer plantSpriteRenderer;
    public Sprite[] plantSprites;

    // Start is called before the first frame update
    void Start()
    {
        state = 0;
        UpdateVisuals();
    }

    public void Action(List<string> items)
    {
        if(state == 3)
        {
            GetReward();
        }

        if(CheckItems(items)){
            if(state < 4)
            {
                state += 1;
            }
            else if(state == 3)
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
                return items.Contains("Seeds");
            case 2:
                waterAudio.PlayWaterSound();
                return items.Contains("WaterCan");
            case 3:
                return true;
            default:
                return items.Contains("Banana");
        }
    }

    private void GetReward()
    {
        // fill in
        Debug.Log("You win");
       plantSpriteRenderer.color = Color.green;
        Instantiate(reward, rewardLocation.position, Quaternion.identity);
    }

    public void UpdateVisuals()
    {
        plantSpriteRenderer.sprite = plantSprites[state];
        Debug.Log("Plant State: " + state);
    }
}
