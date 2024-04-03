using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    public string Victory; // The name of the scene to transition to

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dead")) 
        {
            Debug.Log("Next Scene");
            LoadTargetScene();
        }
    }

    private void LoadTargetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
