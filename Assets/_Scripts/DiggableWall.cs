using UnityEngine;
using UnityEngine.InputSystem;

public class DiggableWall : MonoBehaviour
{
    private bool hasAxe;
    private bool playerNearby;

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
            playerNearby = true;
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
            playerNearby = false;
    }

    private void Update()
    {
        if (playerNearby &&
            Mouse.current != null &&
            Mouse.current.leftButton.wasPressedThisFrame)
        {
            Destroy(gameObject);
        }
    }
}
