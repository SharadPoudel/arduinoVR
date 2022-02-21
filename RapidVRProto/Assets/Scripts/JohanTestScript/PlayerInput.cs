using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private SerialController serialController;
    [SerializeField] private GameObject cube1, cube2, cube3;
    private Renderer cube1R, cube2R, cube3R;

    
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();
        cube1R = cube1.GetComponent<Renderer>();
        cube2R = cube2.GetComponent<Renderer>();
        cube3R = cube3.GetComponent<Renderer>();
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
            Debug.Log("Message arrived: " + ChangeCubeColor(message));       
        }
            
    }

    private String ChangeCubeColor(String message)
    {
        switch (message)
        {
            case "S1On":
                cube1R.material.color = Color.blue;
                break;
            case "S1Off":
                cube1R.material.color = Color.black;
                break;
            case "S2On":
                cube2R.material.color = Color.blue;
                break;
            case "S2Off":
                cube2R.material.color = Color.black;
                break;
            case "S3On":
                cube3R.material.color = Color.blue;
                break;
            case "S3Off":
                cube3R.material.color = Color.black;
                break;
        }
        return message;
    }
}


