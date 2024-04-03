using UnityEngine;

public class Narrator3 : MonoBehaviour
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

    public AudioClip elevatorClip;
    public AudioClip reviewClip;
    public AudioClip rantClip;
    public AudioClip contractClip;

    private AudioSource constructionAudio;

    public void Start()
    {
        constructionAudio = NaratorManager2.Instance.Construction;
        PlaySound(elevatorClip);
    }

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
        StopConstructionSound();
        StopSound(clip);
        PlaySound(clip);
    }

    public void StopConstructionSound()
    {
        if (constructionAudio.isPlaying)
        {
            constructionAudio.Stop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hasPlayed1 && other.CompareTag("Construction"))
        {
            StopSound(elevatorClip);
            NaratorManager2.Instance.Construction.Play();
            hasPlayed1 = true;
        }

        if (!hasPlayed2 && other.CompareTag("Review"))
        {
            StopConstructionSound();
            PlaySound(reviewClip);
            hasPlayed2 = true;
        }
    }
}