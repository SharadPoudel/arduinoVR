using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Button : MonoBehaviour
{
    public string sensorName;
    public bool buttonDown = false;

    [SerializeField] private float durationLimit = 0.5f;
    [SerializeField] public Material pressedColor, defaultColor;

    private float buttonPressDuration = 0;
    private bool pressing, colorLocked, holding = false;
   
    void Start()
    {
        gameObject.GetComponent<Renderer>().material = defaultColor;

    }


    void Update()
    {

    }

    public void PressButton(string status)
    {


        colorLocked = (Time.time <= buttonPressDuration);
        pressing = (status == "On");

       // Debug.Log("pressing");

        if (!colorLocked)
        {

            if (pressing && !holding)
            {
                ChangeColor(pressedColor);
                buttonDown = true;
                buttonPressDuration = (durationLimit + Time.time);
                holding = true;
                
                





            }
            else if (!pressing)
            {
                ChangeColor(defaultColor);
                buttonDown = false;
                holding = false;
            }
            else
            {
                ChangeColor(defaultColor);
                buttonDown = false; ;
            }
        }
        else
        {
            ChangeColor(pressedColor);
            buttonDown = true;
            if (pressing)
                holding = true;
        }

        //Debug.Log(holding + "__" + Time.time + "__" + sensorName + "__" + gameObject.GetComponent<Renderer>().material);


    }

    private void ChangeColor(Material material)
    {
        gameObject.GetComponent<Renderer>().material = material;
    }

}







