using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour
{
    [SerializeField] private float startDelay = 2;
    [SerializeField] private int bpm;
    public NoteInfo[] noteList;


    void Start()
    {

    }


    void Update()
    {

    }
}

[Serializable]
public struct NoteInfo
{
    public GameObject noteType;
    public int lane;
}
