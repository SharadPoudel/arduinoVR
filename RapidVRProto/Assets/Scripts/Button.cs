using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private float buttonPressLimit = 1f;
    [SerializeField] private Material defaultColor, pressedColor;
    [SerializeField] private String sensorName;

    private float cdCounter;
    void Start()
    {
        cdCounter = 0;
        gameObject.GetComponent<Renderer>().material = default;
    }

     
    void Update()
    {
        cdCounter += Time.deltaTime;
    }

    public String PressButton(String message)
    {
        //Getting the sensor name and if it should be on or off
        String[] messageSplit = message.Split('_');
        //Debug.Log("test");
        if(messageSplit[0] == sensorName && messageSplit[1] == "On" && cdCounter <= buttonPressLimit)
        {
            gameObject.GetComponent<Renderer>().material = pressedColor;
            cdCounter = buttonPressLimit;
            
        }else 
        {
            gameObject.GetComponent<Renderer>().material = defaultColor;
            cdCounter = 0;
        }
        
        return message;
    }
}
