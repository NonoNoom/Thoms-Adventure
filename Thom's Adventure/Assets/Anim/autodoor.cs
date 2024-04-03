using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autodoor : MonoBehaviour
{
    public Animator doorAnim;

    public object key;

    private void OnTriggerEnter(Collider other)
    {
        if (KeyBool.Unlocked && other.CompareTag("Door"))
        {
            doorAnim.SetTrigger("open");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            doorAnim.SetTrigger("close");
        }
    }
}
