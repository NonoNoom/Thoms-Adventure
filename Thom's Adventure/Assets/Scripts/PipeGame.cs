using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGame : MonoBehaviour
{
    public GameObject pipeUI;
    public GameObject cursorUI;

    private void Start()
    {
        pipeUI.SetActive(!pipeUI.activeSelf);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Pipes") && pipeUI.activeSelf)
        {
            Debug.Log("Close");
            ClosePipeUI();
        }
        else if (Input.GetButtonDown("Pipes") && !pipeUI.activeSelf)
        {
            Debug.Log("Open");
            OpenPipeUI();
        }
    }

    public void OpenPipeUI()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        cursorUI.SetActive(!cursorUI.activeSelf);
        pipeUI.SetActive(!pipeUI.activeSelf);
        Debug.Log("Start UI");
    }

    public void ClosePipeUI()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        pipeUI.SetActive(!pipeUI.activeSelf);
        cursorUI.SetActive(!cursorUI.activeSelf);
        Debug.Log("close UI");
    }
}
