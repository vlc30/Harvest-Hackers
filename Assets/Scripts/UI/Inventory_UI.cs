using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Inventory_UI : MonoBehaviour
{
    public GameObject inventoryPanel;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleInventory();
        }
    }
    public void ToggleInventory()
    {
        //check cur state
        //if off, turn on
        if (!inventoryPanel.activeSelf)
        {
            inventoryPanel.SetActive(true);
        }
        // if on, turn off
        else
        {
            inventoryPanel.SetActive(false);
        } 
    }
}
