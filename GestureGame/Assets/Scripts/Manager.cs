using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manager : MonoBehaviour {


    public bool object1 = true;
    public bool object2 = false;
    public bool object3 = false;
    public bool object4 = false;
    public GameObject mono;
    //GENERAL
    public float level;
    public GameObject scene;
    public float scrolling = -528;

    //OBJECT 01
    public bool stop_01 = false;
    public GameObject cube1;
    public Detection1 detect1;

    //OBJECT 02
    public bool stop_02 = false;
    public GameObject cube2;
    public Detection2 detect2;

    //OBJECT 03
    public bool stop_03 = false;
    public GameObject cube3;
    public Detection3 detect3;

    //OBJECT 04
    public bool stop_04 = false;
    public GameObject cube4;
    public Detection4 detect4;


    // Use this for initialization
    void Start ()
    {
        scene.transform.localPosition = new Vector3(-0, 0.03f, -0);
	}
	
	// Update is called once per frame
	void Update ()
    {
       

        if(object1)
        { 
            //OBJECT 01
            if(stop_01 == false)
            {
                scene.transform.position = new Vector3(0, 0.03f, scrolling);
                scrolling += 0.05f;    
            }

             if(stop_01)
             {
                  if (Input.GetKeyDown(KeyCode.P))
                  {
                        mono.GetComponent<Animator>().enabled = true;

                        cube1.SetActive(false);
                          stop_01 = false;
                          Debug.Log("PULSE");
                          detect1.pulseP.SetActive(false);
                          object2 = true;
                  }
             }
        }
       

        if(object2)
        {
            //OBJECT 02
             if (stop_02 == false)
             {
                         stop_01 = true;
                        scene.transform.position = new Vector3(0, 0.03f, scrolling);
                        scrolling += 0.05f;
             }
             if (stop_02)
             {
                   if (Input.GetKeyDown(KeyCode.S))
                    {
                        mono.GetComponent<Animator>().enabled = true;

                         cube2.SetActive(false);
                         stop_02 = false;
                         Debug.Log("PULSE");
                         detect2.pulseS.SetActive(false);
                         object3 = true;

                   }
             } 
        }
        
        if(object3)
        {
            //OBJECT 03
            if (stop_03 == false)
             {
                stop_02 = true;

                scene.transform.position = new Vector3(0, 0.03f, scrolling);
                  scrolling += 0.05f;
            }
            if (stop_03)
            {
                   if (Input.GetKeyDown(KeyCode.T))
                     {
                         mono.GetComponent<Animator>().enabled = true;

                         cube3.SetActive(false);
                        stop_03 = false;
                        Debug.Log("PULSE");
                        detect3.pulseT.SetActive(false);
                        object4 = true;

                   }
            }
        }
        
        if(object4)
        {
            //OBJECT 04
             if (stop_04 == false)
             {
                stop_03 = true;

                scene.transform.position = new Vector3(0, 0.03f, scrolling);
                   scrolling += 0.05f;
             }
             if (stop_04)
             {
                  if (Input.GetKeyDown(KeyCode.W))
                  {
                         mono.GetComponent<Animator>().enabled = true;

                        cube4.SetActive(false);
                        stop_04 = false;
                        Debug.Log("PULSE");
                        detect4.pulseW.SetActive(false);
                  }
             }
        }       
    }

}
