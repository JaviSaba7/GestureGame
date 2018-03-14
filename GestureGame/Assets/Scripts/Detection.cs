using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Detection : MonoBehaviour {

    public float level;
    public GameObject scene;
    public bool stop;
    public bool reanude;
    public float scrolling = -0;
    

    // Use this for initialization
    void Start ()
    {
        scene.transform.localPosition = new Vector3(0.2084584f, 0.021f, 0f);
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKey(KeyCode.P))
        {
            scene.transform.position = new Vector3(0.2084584f, 0.021f, scrolling);
            scrolling += 0.05f;
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Stop");
        }
    }
}
