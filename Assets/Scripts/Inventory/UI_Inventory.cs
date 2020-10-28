using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 * WIP Inventoy UI
 * -> Currently having issues with RectTransform (see details below)
 */
public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private static Transform itemSlotContainer;
    private static Transform Pokeba11;

    public void Awake()
    {
        itemSlotContainer = transform.Find("itemSlotContainer");
        Pokeba11 = itemSlotContainer;
        //Pokeba11 = itemSlotContainer.Find("Pokeba11");

    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;

        inventory.OnItemListChanged += Inventory_OnItemListChanged;
        RefreshInventory();
    }

    public void Inventory_OnItemListChanged(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }


    public void RefreshInventory()
    {
        foreach (Transform child in itemSlotContainer)
        {
            if (child == Pokeba11) continue;
            Destroy(child.gameObject);
        }
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 30f;
        foreach (Item item in inventory.GetListItem())
        {
            // Line of code Below throws
            /*
             * NullReferenceException: Object reference not set to an instance of an object
             * UI_Inventory.RefreshInventory () (at Assets/Scripts/Inventory/UI_Inventory.cs:35)
             * UI_Inventory.SetInventory (Inventory inventory) (at Assets/Scripts/Inventory/UI_Inventory.cs:25)
             * Player.Start () (at Assets/Scripts/Player/Player.cs:59)
             */
            RectTransform itemSlotRectTransform = Instantiate(Pokeba11, itemSlotContainer).GetComponent<RectTransform>(); // <=

            // Trying to instantiate the Pokeball to show item ^

            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            //Image image = itemSlotRectTransform.Find("pokeball.png").GetComponent<Image>();
            //image.sprite = item.getSprite();
            x++;
            if (x > 4)
            {
                x = 0;
                y++;
            }
        }
    }

}
