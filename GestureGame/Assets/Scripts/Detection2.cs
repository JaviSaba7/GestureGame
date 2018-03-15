using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Detection2 : MonoBehaviour {

    public GameObject mono;

    public Manager manager;
    public GameObject pulseS;
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
            mono.GetComponent<Animator>().enabled = false;

            Debug.Log("Stop2");
            manager.stop_02 = true;
            pulseS.SetActive(true);

        }
        else
        {
            pulseS.SetActive(false);

            manager.stop_02 = false;

        }
    }
}
