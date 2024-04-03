using UnityEngine;

public class Narrator : MonoBehaviour
{
    private bool hasPlayed1 = false;
    private bool hasPlayed2 = false;
    private bool hasPlayed3 = false;
    private bool hasPlayed4 = false;
    private bool hasPlayed5 = false;
    private bool hasPlayed6 = false;
    private bool hasPlayed7 = false;
    private bool hasPlayed8 = false;

    public AudioClip beginClip; 
    public AudioClip hallwayClip;
    public AudioClip twoDoorsClip;
    public AudioClip rightClip;
    public AudioClip leftClip;
    public AudioClip afterTwoDoorsClip;
    public AudioClip fallDamageClip;
    public AudioClip fallDamageTrueClip;
    public AudioClip uiPuzzleClip;

    public AudioSource audioSource;

    void Start()
    {
        if (TryGetComponent<AudioSource>(out audioSource))
        {
            PlaySound(beginClip); 
        }
        else
        {
            Debug.LogError("AudioSource component not found. Make sure it is attached to the GameObject.");
        }
    }

    void PlaySound(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }

    void StopSound()
    {
        audioSource.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hasPlayed1 && other.CompareTag("Hallway"))
        {
            StopSound();
            PlaySound(hallwayClip);
            hasPlayed1 = true;
        }

        if (!hasPlayed2 && other.CompareTag("Two doors"))
        {
            StopSound();
            PlaySound(twoDoorsClip);
            hasPlayed2 = true;
        }

        if (!hasPlayed3 && other.CompareTag("Right"))
        {
            StopSound();
            PlaySound(rightClip);
            hasPlayed3 = true;
        }

        if (!hasPlayed4 && other.CompareTag("Left"))
        {
            StopSound();
            PlaySound(leftClip);
            hasPlayed4 = true;
        }

        if (!hasPlayed5 && other.CompareTag("After two doors"))
        {
            StopSound();
            PlaySound(afterTwoDoorsClip);
            hasPlayed5 = true;
        }

        if (!hasPlayed6 && other.CompareTag("Fall damage"))
        {
            StopSound();
            PlaySound(fallDamageClip);
            hasPlayed6 = true;
        }

      //  if (!hasPlayed7 && other.CompareTag("Fall damage true"))
      //  {
        //    StopSound();
        //    PlaySound(fallDamageTrueClip);
       //     hasPlayed7 = true;
       // }

        //if (!hasPlayed8 && other.CompareTag("UI puzzle"))
      //  {
           // StopSound();
         //   PlaySound(uiPuzzleClip);
         //   hasPlayed8 = true;
       // }
    }
}
