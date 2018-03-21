using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class OnEnter : MonoBehaviour {

    public TextMeshProUGUI counterText;
    public float counter = 3.0f;
    public bool discountTime = false;

    public bool patternCorrect = false;
    // Use this for initialization
    void Start ()
    {
        counterText.text = counter.ToString("3");
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(discountTime)
        {
            counter -= Time.deltaTime;
        }
	}

   
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ActivateCounter();
            ResetTime();
            ActiveBool();
            if(counter <= 0)
            {
                Lose();
            }

            if (patternCorrect) Debug.Log("YOU WIN");

        }

    }

    public void ResetTime()
    {
        counter = 0;
    }

    public void ActiveBool()
    {
        discountTime = true;
    }

    public void DisableBool()
    {
        discountTime = false;
    }

    public void Lose()
    {
        Debug.Log("LOSE!");
    }

    public void ActivateCounter()
    {
        counterText.enabled = true;
    }
}
