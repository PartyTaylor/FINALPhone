using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorCheck : MonoBehaviour {

    public bool buttonInRanged;
    private bool played = false;
    public ItemCounter count;
    int total;
    //private static float minusbat = 10;
    private void Start()
    {
        count = GameObject.FindGameObjectWithTag("Player").GetComponent<ItemCounter>();
    }

    void OnTriggerEnter(Collider col)
    {
        buttonInRanged = true;
    }
    void OnTriggerExit(Collider col)
    {
        buttonInRanged = false;
    }

    public void OnGUI()
    {
        if (buttonInRanged == true)
        {
            if(total >= 4)
            {
                GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 55, 120, 50), "Open Door 'E'");
            }
            else
            {
                GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 55, 120, 50), "Need more Items");
            }
        }
    }

    void Update()
    {
        total = count.getTotalItem();
        if (buttonInRanged == true)
        {
            if (Input.GetKey("e"))
            {
                if(total >= 4)
                {
                        SceneManager.LoadScene("basement");
                }

            }
        }
    }
}
