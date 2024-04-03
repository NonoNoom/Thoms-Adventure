using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource footstepSource;
    public AudioClip footstepSound;
    public AudioClip hallwaySound;

    private bool inHallway = false;
    private bool isMoving = false;

    // Update is called once per frame
    void Update()
    {
        bool isMovingNow = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) ||
                           Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow);

        if (isMovingNow)
        {
            isMoving = true;

            if (inHallway)
            {
                PlayFootstepSound(hallwaySound);
            }
            else
            {
                PlayFootstepSound(footstepSound);
            }
        }
        else
        {
            isMoving = false;
            footstepSource.Stop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hallways"))
        {
            inHallway = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Hallways"))
        {
            inHallway = false;
        }
    }

    private void PlayFootstepSound(AudioClip clip)
    {
        if (!footstepSource.isPlaying || footstepSource.clip != clip)
        {
            footstepSource.clip = clip;
            footstepSource.Play();
        }
    }
}
