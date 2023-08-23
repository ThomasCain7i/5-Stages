using UnityEngine;

public class ZoomOut : MonoBehaviour
{
    public float zoomAmount = 2.0f;    // Amount by which to zoom out

    private Camera mainCamera;
    private float originalOrthoSize;

    private void Start()
    {
        mainCamera = Camera.main;
        originalOrthoSize = mainCamera.orthographicSize;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Zoom out by the specified amount
            mainCamera.orthographicSize += zoomAmount;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Restore the original zoom level
            mainCamera.orthographicSize = originalOrthoSize;
        }
    }
}