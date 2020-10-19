using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/*
 * New Inventory class using List<>
 *
 *
*/
public class Inventory {

    public event EventHandler OnItemListChanged;
    public  List<Item> listItem;

    public Item Pokeball { get; private set; }

    public Inventory()
    {
        listItem = new List<Item>();

        //Testing Inventory
        Debug.Log("Inventory Test");
        addItem(new Item { itemType = Item.ItemType.Pokeball, amount = 1 });
        addItem(new Item { itemType = Item.ItemType.Pokeball, amount = 1 });
        addItem(new Item { itemType = Item.ItemType.Pokeball, amount = 1 });
        Debug.Log(listItem.Count);
        Debug.Log(listItem.ToString());
    }

    // Adds Item to inventory
    public void addItem(Item item)
    {
        listItem.Add(item);
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    // Gets list item
    public List<Item> GetListItem()
    {
        return listItem;
    }

    public String getListString()
    {
        return listItem.ToString();
    }

    public int getListCount()
    {
        return listItem.Count();
    }

    public bool containsPokeball()
    {
        if (listItem.Contains(Pokeball))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
