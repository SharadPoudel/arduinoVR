using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private SerialController serialController;
    [SerializeField] private GameObject cube1, cube2, cube3;

    
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
            Debug.Log("Message arrived: " + message);
            switch (message)
            {
                case "Sensor1":
                    cube1.GetComponent<Renderer>().material.color = Color.blue;
                    break;
                case "Sensor2":
                    cube2.GetComponent<Renderer>().material.color = Color.blue;
                    break;
                case "Sensor3":
                    cube3.GetComponent<Renderer>().material.color = Color.blue;
                    break;
                case "No Signal":
                    cube1.GetComponent<Renderer>().material.color = Color.black;
                    cube2.GetComponent<Renderer>().material.color = Color.black;
                    cube3.GetComponent<Renderer>().material.color = Color.black;
                    break;

            }
        }
            
    }

    private void ChangeCubeColor(String message)
    {

    }
}


