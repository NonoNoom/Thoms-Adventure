using UnityEngine;

public class Narrator4 : MonoBehaviour
{
    private bool hasPlayed1 = false;
    private bool hasPlayed2 = false;
    private bool hasPlayed3 = false;
    private bool hasPlayed4 = false;
    private bool hasPlayed5 = false;
    private bool hasPlayed6 = false;
    private bool hasPlayed7 = false;
    private bool hasPlayed8 = false;

    public AudioSource audioSource;

    public AudioClip rantClip;
    public AudioClip contractClip;

    public void PlaySound(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }

    public void StopSound(AudioClip clip)
    {
        audioSource.Stop();
    }

    public void ResetAndPlaySound(AudioClip clip)
    {
        StopSound(clip);
        PlaySound(clip);
    }
}