using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ajtonyito : MonoBehaviour
{

    public GameObject triggeredObject;
    public GameObject ajto;


    bool triggered = false;

    void  OnTriggerEnter(Collider other)
    {
        /*
        if (!triggered)
        {
            triggeredObject.SetActive(false);
            ajto.SetActive(false);
            
            triggered = true;
        }*/

        if (!triggered)
        {
            ajto.SetActive(false);
            triggeredObject.SetActive(false);
            triggered = true;
        }

    }
}
