using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private bool pressable;
    void Start()
    {
        
    }

    
    void Update()
    {
        Debug.Log(Time.deltaTime);
        transform.Translate(0, 0, -speed * Time.deltaTime);
    }


}
