using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Detection : MonoBehaviour {

    public float level;
    public GameObject scene;
    public bool stop;
    public bool reanude;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(stop)
        {
            scene.GetComponent<Animator>().enabled = false;
            Debug.Log("Stop");
        }

       /* if (reanude)
        {
            scene.GetComponent<Animator>().enabled = true;
            Debug.Log("Reanude");
        }*/
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            stop = true;
            if (Input.GetKey(KeyCode.P))
            {
                reanude = true;
                stop = false;
            }
        }
    }

   



}
