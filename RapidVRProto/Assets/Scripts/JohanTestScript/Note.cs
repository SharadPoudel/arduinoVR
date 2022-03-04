using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    [HideInInspector] public float speed;

    void Start()
    {

    }


    void Update()
    {

        transform.Translate(0, 0, -speed * Time.deltaTime);

    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Button") && other.GetComponent<Button>().buttonDown)
        {
            Destroy(gameObject);
        }else if (other.CompareTag("Fail"))
        {
            Destroy(gameObject);
        }
    }
}
