using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slidingDoors : MonoBehaviour
{
    public Animator slidingdoorAnim_left;
    public Animator slidingdoorAnim_right;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SlidingDoor"))
        {
            slidingdoorAnim_left.SetTrigger("open_left");
            slidingdoorAnim_right.SetTrigger("open_right");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("SlidingDoor"))
        {
            slidingdoorAnim_left.SetTrigger("close_left");
            slidingdoorAnim_right.SetTrigger("close_right");
        }
    }
}
