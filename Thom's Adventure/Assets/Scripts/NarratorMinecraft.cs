using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class NarratorMinecraft : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip voiceLine1;
    public AudioClip voiceLine2;
    public GameObject mySphere;

    private bool switchScene = false;
    private bool voiceLineTriggered = false;

    void Start()
    {
        PlayVoiceLine(voiceLine1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Minecraft") && !voiceLineTriggered)
        {
            audioSource.Stop();
            PlayVoiceLine(voiceLine2);
            voiceLineTriggered = true;
            AnvilBool.Anvil = true;
        }
    }

    IEnumerator WaitAndSpawnSphere(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SpawnSphere();
    }

    void Update()
    {
        if (!audioSource.isPlaying && !switchScene && voiceLineTriggered)
        {
            SceneManager.LoadScene("SuperMario");
            switchScene = true;
        }
    }

    private void PlayVoiceLine(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }

    public void SpawnSphere()
    {
        int spawnPointX = Random.Range(-222, -220);
        int spawnPointY = Random.Range(20, 40);
        int spawnPointZ = Random.Range(-112, -110);

        Vector3 spawPosition = new Vector3(spawnPointX, spawnPointY, spawnPointZ);

        Instantiate(mySphere, spawPosition, Quaternion.identity);
    }
}
