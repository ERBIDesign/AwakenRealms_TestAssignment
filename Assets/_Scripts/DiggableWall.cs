using UnityEngine;
using UnityEngine.InputSystem;

public class DiggableWall : MonoBehaviour
{
    private bool hasAxe;
    private bool playerNearby;
    private InventoryScript inventoryScript;

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            playerNearby = true;
            inventoryScript = col.GetComponent<InventoryScript>();
        }

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
            Mouse.current.leftButton.wasPressedThisFrame &&
            inventoryScript.hasPickaxe)
        {
            Destroy(gameObject);
        }
    }
}
