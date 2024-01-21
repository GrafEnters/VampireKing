using System;
using DefaultNamespace;
using UnityEngine;

public class PlayerInputsController : ComponentsContainer {
    private void Update() {
        if (Input.GetKeyDown(KeyCode.I)) {
            if (InventoryDialog.isActive) {
                UIFactory.CloseInventory();
            } else {
                var i = GetComponent<InventoryComponent>();
                if (i == null) {
                    i = GetComponentInChildren<InventoryComponent>();
                }
                UIFactory.ShowInventory(i.Inventory);
            }
        }
    }
}