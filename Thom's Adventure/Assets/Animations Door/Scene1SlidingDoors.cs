using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1SlidingDoors : MonoBehaviour
{
    [Header("Door 1")]
    public Animator slidingdoorAnim_left1;
    public Animator slidingdoorAnim_right1;

    [Header("Door 2")]
    public Animator slidingdoorAnim_left2;
    public Animator slidingdoorAnim_right2;

    [Header("Door 3")]
    public Animator slidingdoorAnim_left3;
    public Animator slidingdoorAnim_right3;

    [Header("Door 4")]
    public Animator slidingdoorAnim_left4;
    public Animator slidingdoorAnim_right4;

    [Header("Door 5")]
    public Animator slidingdoorAnim_left5;
    public Animator slidingdoorAnim_right5;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SlidingDoor1"))
        {
            slidingdoorAnim_left1.SetTrigger("open_left");
            slidingdoorAnim_right1.SetTrigger("open_right");
        }

        if (other.CompareTag("SlidingDoor2"))
        {
            slidingdoorAnim_left2.SetTrigger("open_left");
            slidingdoorAnim_right2.SetTrigger("open_right");
        }

        if (other.CompareTag("SlidingDoor3"))
        {
            slidingdoorAnim_left3.SetTrigger("open_left");
            slidingdoorAnim_right3.SetTrigger("open_right");
        }

        if (other.CompareTag("SlidingDoor4"))
        {
            slidingdoorAnim_left4.SetTrigger("open_left");
            slidingdoorAnim_right4.SetTrigger("open_right");
        }

        if (other.CompareTag("SlidingDoor5"))
        {
            slidingdoorAnim_left5.SetTrigger("open_left");
            slidingdoorAnim_right5.SetTrigger("open_right");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("SlidingDoor1"))
        {
            slidingdoorAnim_left1.SetTrigger("close_left");
            slidingdoorAnim_right1.SetTrigger("close_right");
        }

        if (other.CompareTag("SlidingDoor2"))
        {
            slidingdoorAnim_left2.SetTrigger("close_left");
            slidingdoorAnim_right2.SetTrigger("close_right");
        }

        if (other.CompareTag("SlidingDoor3"))
        {
            slidingdoorAnim_left3.SetTrigger("close_left");
            slidingdoorAnim_right3.SetTrigger("close_right");
        }

        if (other.CompareTag("SlidingDoor4"))
        {
            slidingdoorAnim_left4.SetTrigger("close_left");
            slidingdoorAnim_right4.SetTrigger("close_right");
        }

        if (other.CompareTag("SlidingDoor5"))
        {
            slidingdoorAnim_left5.SetTrigger("close_left");
            slidingdoorAnim_right5.SetTrigger("close_right");
        }
    }
}
