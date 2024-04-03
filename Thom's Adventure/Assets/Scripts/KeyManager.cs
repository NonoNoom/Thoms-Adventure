using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public Camera playerCam;

    void Update()
    {
        Ray ray = playerCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            GameObject objectHitByRaycast = hit.transform.gameObject;

            if (objectHitByRaycast.TryGetComponent<Outline>(out Outline outline))
            {
                if (objectHitByRaycast.CompareTag("Weapon"))
                {
                    outline.enabled = true;
                }
                else
                {
                    
                    outline.enabled = false;
                }
            }
            else
            {
  
                DisableOutlineOnAllObjects();
            }
        }
        else
        {
            DisableOutlineOnAllObjects();
        }
    }

    void DisableOutlineOnAllObjects()
    {
        Outline[] outlines = FindObjectsOfType<Outline>();
        foreach (Outline o in outlines)
        {
            o.enabled = false;
        }
    }
}
