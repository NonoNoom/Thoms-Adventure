using UnityEngine;

public class Keypick : MonoBehaviour
{
    // Reference to the camera
    public Camera playerCam;

    // Reference to the audio source for the key pickup sound
    public AudioSource keyPickupAudioSource;

    // The key pickup sound clip
    public AudioClip keyPickupSound;

    // Update is called once per frame
    void Update()
    {
        // Cast a ray from the center of the screen
        Ray ray = playerCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        // Check if the ray hits any object
        if (Physics.Raycast(ray, out hit))
        {
            // Check if the hit object has a valid reference
            if (hit.transform != null && hit.transform.gameObject != null)
            {
                GameObject objectHitByRaycast = hit.transform.gameObject;

                // Check if the hit object has the "Weapon" tag
                if (objectHitByRaycast.CompareTag("Weapon"))
                {
                    // Check if the "E" key is pressed
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        // Play the key pickup sound
                        if (keyPickupAudioSource != null && keyPickupSound != null)
                        {
                            keyPickupAudioSource.PlayOneShot(keyPickupSound);
                        }

                        // Destroy the object hit by the raycast
                        Destroy(objectHitByRaycast);
                        KeyBool.Unlocked = true;
                    }
                }
            }
        }
    }
}
