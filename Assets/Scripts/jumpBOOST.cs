using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpBOOST : MonoBehaviour
{
    public playerMove jamp;

    public GameObject triggeredObject;   


    bool triggered = false;

    private void OnTriggerEnter(Collider triggeringdObject)
    {
        if (!triggered)
        {
            triggeredObject.SetActive(false);
            triggered = true;
            jamp.jumpHeight = 30;
        }
    }
}
