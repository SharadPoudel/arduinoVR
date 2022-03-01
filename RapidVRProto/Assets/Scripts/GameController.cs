using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour
{
    [SerializeField] private float startDelay = 2;
    [SerializeField] private int bpm;
    [SerializeField] AudioSource audioSource;
    public NoteInfo[] noteList;


    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.PlayDelayed(startDelay);
    }


    void Update()
    {

        //audioSource.PlayDelayed(startDelay);
    }
}

[Serializable]
public struct NoteInfo
{
    public GameObject noteType;
    public int lane;
}
