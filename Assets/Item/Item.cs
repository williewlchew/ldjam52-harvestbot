using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string name;

    public void Remove(){
        Destroy(this.gameObject);
    }
}
