using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Detection4 : MonoBehaviour {

    public GameObject mono;

    public Manager manager;
    public GameObject pulseW;
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

            Debug.Log("Stop4");
            manager.stop_04 = true;
            pulseW.SetActive(true);

        }
        else
        {
            pulseW.SetActive(false);

            manager.stop_04 = false;

        }
    }
}
