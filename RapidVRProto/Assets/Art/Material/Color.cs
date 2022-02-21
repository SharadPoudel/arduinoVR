using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Color : MonoBehaviour
    {
    public Material[] materials;
    public int x;
    private MeshRenderer meshRenderer; //(or you can create a public variable and add the           MeshRenderer in the editor)


    void Start()
        {
        x = 0; 
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = true;
        meshRenderer.sharedMaterial = materials[x];
        }

    void Update()
        {
        meshRenderer.sharedMaterial = materials[x];
        if (Input.GetKeyDown("space"))
            {
            Nextcolor();
            }

        }


    public void Nextcolor()
        {
        if (x < 2)
            {
            x++;
            }
        else
            {
            x = 0;
            }
        }
    }
