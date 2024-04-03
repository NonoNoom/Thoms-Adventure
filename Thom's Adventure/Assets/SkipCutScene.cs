using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipCutScene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Scene 1");
        }
    }
}
