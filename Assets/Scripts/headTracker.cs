using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headTracker : MonoBehaviour
{
    public GameObject panel;
    public GameObject chestTracker;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = panel.GetComponent<adjustOffset>().offset;        
    }
}
