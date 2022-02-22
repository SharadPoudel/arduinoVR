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
            foreach(Button button in buttons)
            {
                Debug.Log(button.GetComponent<Button>().PressButton(message));
            }
                   
        }
            
    }

   
}


