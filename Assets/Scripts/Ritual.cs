using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ritual : MonoBehaviour {

    public bool ritual;
    private bool played = false;
    public Transform Spawnpoint1;
    public Transform Spawnpoint2;
    public Transform Spawnpoint3;
    public Transform Spawnpoint4;

    public GameObject rItem1;
    public GameObject rItem2;
    public GameObject rItem3;
    public GameObject rItem4;
    // Use this for initialization
    void Start () {
		
	}
	
    void OnTriggerEnter(Collider col)
    {
        ritual = true;
    }

    void OnTriggerExit(Collider col)
    {
        ritual = false; 

    }

    public void OnGUI()
    {
        if (ritual == true)
        {
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 55, 120, 50), "place the ritual items 'E'");
        }
    }
    // Update is called once per frame
    void Update () {

        if (ritual == true)
        {
            if (Input.GetKey("e"))
            {
                if (!played)
                {
                    Instantiate(rItem1, Spawnpoint1.position, Spawnpoint1.rotation);
                    Instantiate(rItem2, Spawnpoint2.position, Spawnpoint2.rotation);
                    Instantiate(rItem3, Spawnpoint3.position, Spawnpoint3.rotation);
                    Instantiate(rItem4, Spawnpoint4.position, Spawnpoint4.rotation);
                    played = true;
                }

            }
        }

    }
}
