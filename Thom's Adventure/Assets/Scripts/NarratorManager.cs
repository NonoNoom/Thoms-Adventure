using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarratorManager : MonoBehaviour
{
    public static NarratorManager Instance { get; set;}

    public AudioSource Hallway;
    public AudioSource TwoDoors;
    public AudioSource Right;
    public AudioSource Left;
    public AudioSource AfterTwoDoors;
    public AudioSource FallDamage;
    public AudioSource FallDamageTrue;
    public AudioSource UIPuzzle;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }
}
