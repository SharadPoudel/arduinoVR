using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private SerialController serialController;
    [SerializeField] private Button[] buttons;



    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();


    }


    void Update()
    {
        string message = serialController.ReadSerialMessage();

        if (message == null)
            return;

        if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_CONNECTED))
            Debug.Log("Connection established");
        else if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_DISCONNECTED))
            Debug.Log("Connection attempt failed or disconnection detected");
        else
        {
            CallingButtons(message);
        }

    }

    private void CallingButtons(string message)
    {
        foreach (Button button in buttons)
        {
            string[] messageSplit = message.Split('_');
            if (button.sensorName == messageSplit[0])
                button.GetComponent<Button>().PressButton(messageSplit[1]);
            if(messageSplit[0] == "Sensor1")
            {
                //Debug.Log(messageSplit[1] + "____" + Time.time);
            }
                
        }
    }


}


