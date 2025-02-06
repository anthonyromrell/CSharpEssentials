using System.Collections;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Give GameObject drag with mouse functionality
/// </summary>
public class DraggableBehaviour : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 offsetFromMouseToObj;
    private Vector3 newPosition;

    [SerializeField] private UnityEvent startDragEvent;

    [SerializeField] private UnityEvent endDragEvent;

    private bool IsDragging { get; set; }

    private void Start()
    {
        mainCamera = Camera.main;
    }

    /// <summary>
    /// Called by Unity on mouse down
    /// </summary>
    private IEnumerator OnMouseDown()
    {
        StartDrag();

        while (IsDragging)
        {
            yield return new WaitForFixedUpdate();
            UpdatePosition();
        }
    }

    private void StartDrag()
    {
        offsetFromMouseToObj = GetOffsetFromMouseToObj();
        IsDragging = true;
        startDragEvent.Invoke();
    }

    /// <summary>
    /// Calculate the distance between the mouse cursor and the object
    /// </summary>
    private Vector3 GetOffsetFromMouseToObj()
    {
        var objectPositionInWorld = transform.position;
        var mousePositionInWorld = GetMousePositionInWorld();
        return objectPositionInWorld - mousePositionInWorld;
    }

    /// <summary>
    /// Transform the mouse position from screen point to world point
    /// </summary>
    private Vector3 GetMousePositionInWorld() => mainCamera.ScreenToWorldPoint(Input.mousePosition);

    private void UpdatePosition()
    {
        newPosition = GetMousePositionInWorld() + offsetFromMouseToObj;
        transform.position = newPosition;
    }

    /// <summary>
    /// Called by Unity when the mouse no longer clicks the object
    /// </summary>
    private void OnMouseUp()
    {
        IsDragging = false;
        endDragEvent.Invoke();
    }
}