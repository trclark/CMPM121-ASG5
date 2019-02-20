using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    //public GameObject trigger1;
    public Camera mainc;
    public Camera cam1;

    // Start is called before the first frame update
    void Start()
    {
        //trigger1 = GameObject.Find("trigger1");
        mainc = Camera.main;
        mainc.enabled = true;
        cam1.enabled = false;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (mainc.enabled)
            {
                mainc.enabled = false;
                cam1.enabled = true;
            }
            else
            {
                cam1.enabled = false;
                mainc.enabled = true;
            }
        }
    }
}
