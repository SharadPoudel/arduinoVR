using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Button : MonoBehaviour
{
    public string sensorName;

    [SerializeField] private float durationLimit = 0.5f;
    [SerializeField] private Material defaultColor, pressedColor;

    private float buttonPressDuration = 0;
    private Boolean pressing, colorLocked, holding = false;
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



        if (!colorLocked)
        {

            if (pressing && !holding)
            {
                ChangeColor(pressedColor);
                buttonPressDuration = (durationLimit + Time.time);
                holding = true;
                //Debug.Log( buttonPressDuration);
            }
            else if(!pressing)
            {
                ChangeColor(defaultColor);
                holding = false;
            }
            else
            {
                ChangeColor(defaultColor);
            }
        }
        else
        {
            ChangeColor(pressedColor);
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
