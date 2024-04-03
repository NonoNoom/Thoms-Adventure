using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoors : MonoBehaviour
{
    public Animator elevatorAnim;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SlidingDoor3"))
        {
            elevatorAnim.SetTrigger("open");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("SlidingDoor3"))
        {
            elevatorAnim.SetTrigger("close");
        }
    }
}
