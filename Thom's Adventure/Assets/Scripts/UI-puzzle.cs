using UnityEngine;

public class UIPuzzle : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip voiceLine;

    private bool voiceLinePlayed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("UI") && !voiceLinePlayed)
        {
            audioSource.PlayOneShot(voiceLine);
            voiceLinePlayed = true;
        }
    }
}
