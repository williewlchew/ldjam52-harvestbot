using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPhase : MonoBehaviour
{
    public List<SwitchObject> objectList;

    public void EnablePhase()
    {
        foreach(SwitchObject switchObject in objectList)
        {
            switchObject.EnableObject();
        }
    }

    public void DisablePhase()
    {
        foreach(SwitchObject switchObject in objectList)
        {
            switchObject.DisableObject();
        }
    }
}
