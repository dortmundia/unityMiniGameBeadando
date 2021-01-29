using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public GameObject triggeredObject;
    public AudioSource audio;


    bool triggered = false;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider triggeringdObject)
    {
        if (!triggered)
        {
            audio.Play();
            triggered = true;
        }
    }
}
