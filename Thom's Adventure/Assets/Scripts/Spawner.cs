using System.Collections;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject mySphere;
    public AudioSource audioSource;
    public AudioClip anvilSound;
    private bool played = false; // Corrected initialization of the boolean variable

    private void Update()
    {
        if (AnvilBool.Anvil && !played) // Corrected comparison operator
        {
            StartCoroutine(SpawnThreeTimesWithDelay(35f, 0.5f));
            played = true;
        }
    }

    private IEnumerator SpawnThreeTimesWithDelay(float totalDelay, float spawnDelay)
    {
        yield return new WaitForSeconds(totalDelay);

        for (int i = 0; i < 3; i++)
        {
            SpawnSphere();
            yield return new WaitForSeconds(spawnDelay);
        }
    }

    public void SpawnSphere()
    {
        int spawnPointX = Random.Range(-200, -202);
        int spawnPointY = Random.Range(20, 40);
        int spawnPointZ = Random.Range(-50, -45);

        Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointZ);

        Instantiate(mySphere, spawnPosition, Quaternion.identity);

        StartCoroutine(PlayAnvilSoundWithDelay(2.5f));
    }

    private IEnumerator PlayAnvilSoundWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        audioSource.PlayOneShot(anvilSound);
    }
}
