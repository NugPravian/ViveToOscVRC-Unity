using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestTracker : MonoBehaviour
{
    public GameObject osc_Service;
    void start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = osc_Service.GetComponent<OSC_Service>().chestTrackerPosition; 
    }
}
