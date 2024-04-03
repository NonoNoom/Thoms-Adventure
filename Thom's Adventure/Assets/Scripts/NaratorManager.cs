using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaratorManager2 : MonoBehaviour
{
    public static NaratorManager2 Instance { get; set;}

    public AudioSource Construction;
    public AudioSource Elevator;
    

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