using System.Collections;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoController1 : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nextSceneName;

    void Start()
    {
        
        videoPlayer.loopPointReached += OnVideoEnd;

       
        videoPlayer.Play();
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        
        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
        
        yield return new WaitForSeconds(1.0f);

        
        SceneManager.LoadScene("Scene 1");
    }
}
