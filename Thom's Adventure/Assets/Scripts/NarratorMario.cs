using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NarratorMario : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip voiceLine1;
    public string nextSceneName;

    private bool isVoiceLine1Playing = false;

    void Start()
    {
        StartCoroutine(PlayVoiceLine1());
    }

    IEnumerator PlayVoiceLine1()
    {
        // Play VoiceLine 1
        isVoiceLine1Playing = true;
        audioSource.clip = voiceLine1;
        audioSource.Play();

        // Wait for VoiceLine 1 to finish playing
        yield return new WaitForSeconds(voiceLine1.length);

        // Switch to the next scene
        SceneManager.LoadScene(nextSceneName);
    }
}
