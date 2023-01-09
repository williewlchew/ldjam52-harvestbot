using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour
{
    public string name;
    public bool finalItem = false;
    public string nextLevelName;


    public void Remove(){

        if(finalItem)
        {
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nextLevelName);
            
        }

        Destroy(this.gameObject);
    }
}
