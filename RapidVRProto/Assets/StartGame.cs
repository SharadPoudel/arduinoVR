using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private Button[] buttons;
    void Start()
    {
        
    }

 
    void Update()
    {
        CheckAllButtons();
    }

    private void CheckAllButtons()
    {
        //Checking if all buttons are being pressed
        foreach (Button button in buttons)
        {
            if (!button.buttonDown)
            {
                return;
            }       
        }

        Debug.Log("yes " + Time.time);
        //do whatever you want here, like changing scenes...
    }
}
