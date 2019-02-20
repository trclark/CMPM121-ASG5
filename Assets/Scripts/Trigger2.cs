using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    //public GameObject trigger1;
    public Camera cam1;
    public Camera cam2;

    // Start is called before the first frame update
    void Start()
    {
        //trigger1 = GameObject.Find("trigger1");
        //cam1 = Camera.main;
        //mainc.enabled = true;
        //cam1.enabled = false;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (cam1.enabled)
            {
                cam1.enabled = false;
                cam2.enabled = true;
            }
            else
            {
                cam2.enabled = false;
                cam1.enabled = true;
            }
        }
    }
}
