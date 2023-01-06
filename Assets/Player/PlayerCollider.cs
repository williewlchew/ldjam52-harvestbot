using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Hazard"){
            Destroy(this.gameObject);
        }
    }
}
