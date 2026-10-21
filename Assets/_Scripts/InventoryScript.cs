using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public bool hasPickaxe;

    void Start()
    {
        hasPickaxe = false;
    }

    void Update()
    {
        
    }

    public void PickupPickaxe()
    {
        hasPickaxe = true;
    }
}
