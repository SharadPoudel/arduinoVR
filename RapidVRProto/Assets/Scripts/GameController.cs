using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour
{
    [SerializeField] private float noteSpeed;
    [SerializeField] private float startDelay;
    [SerializeField] private float bpm;
    [SerializeField] private float[] lanePosX;
    [SerializeField] private NoteInfo[] noteList;
    

    
    private float beatLength;
    private bool playingMusic = false;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        PLacingNotes();
    }


    void Update()
    {
        if (!playingMusic && Time.time >= startDelay)
        {
            audioSource.Play();
            playingMusic = true;
 
        }
    }

    void PLacingNotes()
    {
        beatLength = 60 / bpm;
        foreach (NoteInfo note in noteList)
        {
            float noteXpos = lanePosX[note.lane - 1];
            //The distance between notes     +   The distance from buttons
            float noteZpos = (note.beatNumber * beatLength * noteSpeed) + (startDelay * noteSpeed);
            GameObject newNote = Instantiate(note.noteType, transform.position + new Vector3(noteXpos, 0.6f, noteZpos), Quaternion.identity, gameObject.transform);
            //newNote.transform.localRotation = gameObject.transform.rotation;
            newNote.GetComponent<Note>().speed = noteSpeed;
        }
    }
}

[Serializable]
public struct NoteInfo
{
    public int beatNumber, lane;
    public GameObject noteType;   
}

