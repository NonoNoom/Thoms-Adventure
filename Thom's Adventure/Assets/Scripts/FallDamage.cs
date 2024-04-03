using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDamage : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Debug.Log("Next Scene");
            SceneManager.LoadScene("FallDead");
        }
    }
}
