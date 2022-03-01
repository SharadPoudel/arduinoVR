using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    
    void Update()
    {
        Debug.Log(Time.deltaTime);
        transform.Translate(0, 0, -speed * Time.deltaTime);
    }
}
