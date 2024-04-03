using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorsounds1 : MonoBehaviour
{
    public AudioSource doorAudioSource;
    public AudioClip openSound;
    public AudioClip closeSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SlidingDoor1"))
        {
           doorAudioSource.PlayOneShot(openSound);
        }

        if (other.CompareTag("SlidingDoor2"))
        {
            doorAudioSource.PlayOneShot(openSound);
        }

        if (other.CompareTag("SlidingDoor3"))
        {
            doorAudioSource.PlayOneShot(openSound);
        }

        if (other.CompareTag("SlidingDoor4"))
        {
            doorAudioSource.PlayOneShot(openSound);
        }

        if (other.CompareTag("SlidingDoor5"))
        {
            doorAudioSource.PlayOneShot(openSound);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("SlidingDoor1"))
        {
            doorAudioSource.PlayOneShot(closeSound);
        }

        if (other.CompareTag("SlidingDoor2"))
        {
            doorAudioSource.PlayOneShot(closeSound);
        }

        if (other.CompareTag("SlidingDoor3"))
        {
     doorAudioSource.PlayOneShot(closeSound);
        }

        if (other.CompareTag("SlidingDoor4"))
        {
            doorAudioSource.PlayOneShot(closeSound);
        }

        if (other.CompareTag("SlidingDoor5"))
        {
            doorAudioSource.PlayOneShot(closeSound);
        }
    }
}
