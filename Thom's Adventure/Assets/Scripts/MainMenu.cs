using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject settingsButton;
    public GameObject cursor;

    public bool settings = false;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        Settings();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExtraGame()
    {
        SceneManager.LoadScene("CCTV Room");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void Settings()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && !settings)
        {
            settings = true;
            settingsMenu.gameObject.SetActive(!settingsMenu.gameObject.activeSelf);
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && settings)
        {
            settings = false;
            settingsMenu.gameObject.SetActive(!settingsMenu.gameObject.activeSelf);
        }

        if (settingsMenu.gameObject.activeSelf)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (!settingsMenu.gameObject.activeSelf)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
