using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CharacterController))]

public class Staminabar : MonoBehaviour {

    public float staminaDrain = 5F;
    public float stamina = 100;
    public float maxstamina = 100;
    public Image currentstamina;

    protected CharacterController cm;
    protected Vector3 move = Vector3.zero;

    public float walkspeed = 1f;

    public bool run;

    // Use this for initialization
    void Start ()
    {
        cm = gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            run = true; 
            if (stamina == 0)
            {
                run = false;
                cm.Move(move * walkspeed * Time.deltaTime);
                Update();
            }
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            run = false;
        }

        if (run == true && stamina >= 0)
        {
            stamina -= Time.deltaTime * staminaDrain;
            float ratio = stamina / maxstamina;
            currentstamina.rectTransform.localScale = new Vector3(ratio, 1, 1);
        }
        if (run == false && stamina >= 0)
        {
            stamina += Time.deltaTime * 2;
            float ratio = stamina / maxstamina;
            currentstamina.rectTransform.localScale = new Vector3(ratio, 1, 1);
        }
        if (stamina <= 0 )
        {
            run = false;
            stamina += Time.deltaTime * 2;
            float ratio = stamina / maxstamina;
            currentstamina.rectTransform.localScale = new Vector3(ratio, 1, 1);
        }
	}
}
