using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PipeScript : MonoBehaviour, IPointerDownHandler
{
    float[] rotations = { 0, 90, 180, 270 };

    public float[] correctRotation;
    [SerializeField]
    bool isPlaced = false;

    int PossibleRots = 1;
    float rotationTolerance = 0.1f; // Define a tolerance for rotation comparison

    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Start()
    {
        PossibleRots = correctRotation.Length;
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);

        CheckRotation(); // Check if the initial rotation is correct
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Click");
        transform.Rotate(new Vector3(0, 0, -90));

        CheckRotation(); // Check if the rotation after user interaction is correct
    }

    private void CheckRotation()
    {
        float currentRotationZ = Mathf.Round(transform.eulerAngles.z); // Round to nearest integer for comparison

        foreach (float rot in correctRotation)
        {
            if (Mathf.Abs(rot - currentRotationZ) < rotationTolerance && !isPlaced)
            {
                isPlaced = true;
                gameManager.correctMove();
                return;
            }
        }

        if (isPlaced)
        {
            isPlaced = false;
            gameManager.wrongMove();
        }
    }
}
