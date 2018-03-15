using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Detection3 : MonoBehaviour {


    public Manager manager;
    public GameObject pulseT;
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
            Debug.Log("Stop3");
            manager.stop_03 = true;
            pulseT.SetActive(true);

        }
        else
        {
            pulseT.SetActive(false);

            manager.stop_03 = false;

        }
    }
}
