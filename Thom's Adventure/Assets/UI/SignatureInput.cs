using UnityEngine;
using UnityEngine.UI;

public class SignatureInput : MonoBehaviour
{
    public RawImage signatureImage;
    public Texture2D blankTexture;
    public float dotSize = 2f; 
    public Color drawColor = Color.black; 
    public float drawRate = 0f; 

    private bool isDrawing = false;
    private float lastDrawTime;
    private Texture2D texture;
    private RectTransform signatureRectTransform;

    void Start()
    {
        signatureRectTransform = signatureImage.rectTransform;
        InitializeTexture();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isDrawing = true;
            DrawDotIfWithinBounds(GetLocalMousePosition());
            lastDrawTime = Time.time;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDrawing = false;
        }

        if (isDrawing && Time.time - lastDrawTime > drawRate)
        {
            DrawDotIfWithinBounds(GetLocalMousePosition());
            lastDrawTime = Time.time;
        }
    }

    private void InitializeTexture()
    {
        int textureWidth = Mathf.RoundToInt(signatureRectTransform.sizeDelta.x);
        int textureHeight = Mathf.RoundToInt(signatureRectTransform.sizeDelta.y);

        texture = new Texture2D(textureWidth, textureHeight, TextureFormat.RGBA32, false);
        ClearTexture();

        Color[] clearColor = new Color[textureWidth * textureHeight];
        for (int i = 0; i < clearColor.Length; i++)
        {
            clearColor[i] = Color.white;
        }

        texture.SetPixels(clearColor);
        texture.Apply();
        signatureImage.texture = texture;
    }

    private void DrawDotIfWithinBounds(Vector2 localPoint)
    {
        if (localPoint.x >= 0 && localPoint.x < texture.width &&
            localPoint.y >= 0 && localPoint.y < texture.height)
        {
            DrawDot(localPoint);
        }
    }

    private void DrawDot(Vector2 localPoint)
    {
        int x = Mathf.Clamp(Mathf.RoundToInt(localPoint.x), 0, texture.width - 1);
        int y = Mathf.Clamp(Mathf.RoundToInt(localPoint.y), 0, texture.height - 1);

        texture.SetPixel(x, y, drawColor);

        int halfDotSize = Mathf.FloorToInt(dotSize / 2);
        for (int i = -halfDotSize; i <= halfDotSize; i++)
        {
            for (int j = -halfDotSize; j <= halfDotSize; j++)
            {
                int px = Mathf.Clamp(x + i, 0, texture.width - 1);
                int py = Mathf.Clamp(y + j, 0, texture.height - 1);
                texture.SetPixel(px, py, drawColor);
            }
        }
        texture.Apply();
    }

    private Vector2 GetLocalMousePosition()
    {
        Vector2 mousePosition = Input.mousePosition;
        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(signatureRectTransform, mousePosition, Camera.main, out localPoint);
        return localPoint + new Vector2(signatureRectTransform.sizeDelta.x / 2, signatureRectTransform.sizeDelta.y / 2);
    }

    private void ClearTexture()
    {
        // Clear the texture by setting all pixels to transparent
        Color[] clearColor = new Color[texture.width * texture.height];
        for (int i = 0; i < clearColor.Length; i++)
        {
            clearColor[i] = Color.clear;
        }
        texture.SetPixels(clearColor);
        texture.Apply();
    }

    public void ClearSignature()
    {
        ClearTexture();
    }
}
