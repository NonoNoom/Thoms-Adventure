using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public static Button Instance { get; set; }
    
    public Button hoveredButton= null; // Consider removing or using 'hover' if needed

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

 private void Update()
{
    Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
    RaycastHit hit;

    if (Physics.Raycast(ray, out hit))
    {
        GameObject objectHitByRaycast = hit.transform.gameObject;

        if (objectHitByRaycast.GetComponent<Button>())
        {
            Debug.Log("Button selected");
            hoveredButton = objectHitByRaycast.GetComponent<Button>();
            hoveredButton.GetComponent<Outline>().enabled = true;
        }
        else
        {
            if (hoveredButton)
            {
                hoveredButton.GetComponent<Outline>().enabled = false;
            }
        }
    }
}
}


