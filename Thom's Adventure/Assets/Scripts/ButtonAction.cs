using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAction : MonoBehaviour, IInteractable
{
    public Animator buttonAnim;
    public GameObject contractUI;
    public GameObject cursorUI;

    private bool pressed = false;

    public Narrator3 narrator;
    public Narrator4 narrator2;

    public void Interact()
    {
        if (gameObject.CompareTag("Rant") && !pressed)
        {
            Debug.Log("Button pressed - rant");
            buttonAnim.SetTrigger("pressed");
            pressed = true;
            if (SceneManager.GetActiveScene().name == "Scene 3")
            {
                narrator.StopConstructionSound();
                StartCoroutine(PlayRantAndLoadScene());
            }
            else
            {
                StartCoroutine(PlayRantAndLoadScene2());
            }
        }

        else if (gameObject.CompareTag("Uwu") && !pressed)
        {
            Debug.Log("Button pressed - reset");
            buttonAnim.SetTrigger("pressed");
            pressed = true;
            SceneManager.LoadScene("Scene 4");
        }

        else if (gameObject.CompareTag("NomiLeerTagsMaken") && !pressed)
        {
            Debug.Log("Button pressed - contract");
            buttonAnim.SetTrigger("pressed");
            pressed = true;
            if (SceneManager.GetActiveScene().name == "Scene 3")
            {
                narrator.StopConstructionSound();
                narrator.PlaySound(narrator.contractClip);
                OpenContract();
            }
            else
            {
                narrator2.PlaySound(narrator2.contractClip);
                OpenContract();
            }
        }
    }

    public void OpenContract()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        contractUI.gameObject.SetActive(!contractUI.gameObject.activeSelf);
        cursorUI.gameObject.SetActive(!cursorUI.gameObject.activeSelf);
    }

    public void CreditScene()
    {
        Debug.Log("Credit scene loading");
        SceneManager.LoadScene("CreditScene");
    }

    IEnumerator PlayRantAndLoadScene()
    {
        narrator.PlaySound(narrator.rantClip);
        yield return new WaitForSeconds(narrator.rantClip.length);
        SceneManager.LoadScene("Minecraft");
    }

    IEnumerator PlayRantAndLoadScene2()
    {
        narrator2.PlaySound(narrator2.rantClip);
        yield return new WaitForSeconds(narrator2.rantClip.length);
        SceneManager.LoadScene("Minecraft");
    }
}
