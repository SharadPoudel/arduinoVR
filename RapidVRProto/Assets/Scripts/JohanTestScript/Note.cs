using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    [HideInInspector] public float speed;
    [SerializeField] private ParticleSystem hitParticle;
    public int forceLimit;

   void Start()
    {

    }


    void Update()
    {

        transform.Translate(0, 0, -speed * Time.deltaTime);

    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Button"))
        {
            if (other.GetComponent<Button>().buttonDown && other.GetComponent<Button>().pressForce >= forceLimit)
            {
                ParticleSystem ps = Instantiate(hitParticle, gameObject.transform.position, Quaternion.identity);
                Destroy(ps.gameObject, 5f);
                Destroy(gameObject);
            }
            
        }
        else if (other.CompareTag("Fail"))
        {
            Destroy(gameObject);
        }
    }
}
