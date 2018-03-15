using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Detection1 : MonoBehaviour {


    public Manager manager;
    public GameObject pulseP;
    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Stop");
            manager.stop_01 = true;
            pulseP.SetActive(true);

        }
        else
        {
            pulseP.SetActive(false);

            manager.stop_01 = false;

        }
    }
}
