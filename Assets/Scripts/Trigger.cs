using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject triggeredObject;   


    bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!triggered)
        {
            triggeredObject.SetActive(false);
            triggered = true;
        }
    }
}
