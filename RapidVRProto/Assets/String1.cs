using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class String1 : MonoBehaviour
{

    public KeyCode activateString;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(activateString))
            {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 1f);
            
            StartCoroutine(retractCollider());
            }
    }

    IEnumerator retractCollider()
        {
        yield return new WaitForSeconds(.75f);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -1f);//moving back
        yield return new WaitForSeconds(.75f);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);//make it at rest

        }
    }
