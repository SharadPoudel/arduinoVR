using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour
{
    
    [SerializeField] private float startDelay = 2;
    [SerializeField] private float bpm;
    [SerializeField] AudioSource audioSource;
    [SerializeField] private float[] lanePositions;
    [SerializeField] private NoteInfo[] noteList;


    private float beatLength;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.PlayDelayed(startDelay);
        beatLength = 60 / bpm;
        foreach(NoteInfo note in noteList)
        {
            float noteXpos = lanePositions[note.lane - 1];
            float noteZpos = note.beatNumber * beatLength;
            GameObject newNote = Instantiate(note.noteType, new Vector3(noteXpos, 0, noteZpos), Quaternion.identity);
            newNote.transform.SetParent(transform);
        }
    }


    void Update()
    {

        
    }
}

[Serializable]
public struct NoteInfo
{
    public int beatNumber, lane;
    public Transform parent;
    public GameObject noteType;

    
}
