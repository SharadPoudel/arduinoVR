using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Button : MonoBehaviour
{
    [HideInInspector] public string sensorName;
    [HideInInspector] public bool buttonDown = false;
    [HideInInspector] public int pressForce = 0;


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
        if (buttonDown)
            ChangeColor(pressedColor);
        else
            ChangeColor(defaultColor);

    }

    public void PressButton(int force)
    {
        colorLocked = (Time.time <= buttonPressDuration);
        pressing = (force >= 5);



        if (!colorLocked)
        {
            if (pressing && !holding)
            {
                pressForce = force;
                buttonDown = true;
                buttonPressDuration = (durationLimit + Time.time);
                holding = true;
            }
            else if (!pressing)
            {
                buttonDown = false;
                holding = false;
            }
            else
            {
                buttonDown = false; ;
            }
        }
        else
        {
            buttonDown = true;
            if (pressing)
                holding = true;
        }
    }

    private void ChangeColor(Material material)
    {
        gameObject.GetComponent<Renderer>().material = material;
    }
}

