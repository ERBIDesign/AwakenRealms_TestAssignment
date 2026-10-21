using UnityEngine;

public class Pickaxe_Script : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            col.GetComponent<InventoryScript>().PickupPickaxe();
            Destroy(gameObject);
            Debug.Log("Pickaxe picked up!");
        }
    }
}
