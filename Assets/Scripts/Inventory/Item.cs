using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Item class for inventory. Currently only made Pokeball.
 * 
 */
public class Item
{
    // This is where to add more Item types (Ex: Pokeball, potion, etc)
    public enum ItemType
    {
        Pokeball,
    }

    public ItemType itemType;
    public int amount;

    // Gets the sprite for the item
    public Sprite getSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Pokeball: return ItemAssets.Instance.pokeball;
        }
    }

    

}

