using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipegameDoors : MonoBehaviour
{
    public Animator slidingdoorAnim_left;
    public Animator slidingdoorAnim_right;

    private GameManager gameManager;

    void Start()
    {
        // Find and store the GameManager in the scene
        gameManager = FindObjectOfType<GameManager>();
        if (gameManager == null)
        {
            Debug.LogError("GameManager not found in the scene!");
        }
    }

    void Update()
    {
        if (gameManager.win)
        {
            slidingdoorAnim_left.SetTrigger("open_left");
            slidingdoorAnim_right.SetTrigger("open_right");
        }
    }
}
