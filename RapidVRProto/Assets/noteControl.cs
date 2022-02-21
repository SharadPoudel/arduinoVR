using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteControl : MonoBehaviour
{
    public Transform sucessBurst;

    public Transform failBurst;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void OnTriggerEnter(Collider other)
   {
        if (other.gameObject.name == "FailCollider")
            {
            Destroy(gameObject);
            Debug.Log("Fail!!!");
            Instantiate(failBurst, transform.position, failBurst.rotation);
            }
        else if (other.gameObject.name == "Success")
            {
            Destroy(gameObject);
            Debug.Log("Success!!!");
            Instantiate(sucessBurst, transform.position, failBurst.rotation);
            GM.winStreak += 1;
            }

        }
}
