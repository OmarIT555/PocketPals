﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{
    /*private Inventory inventory;
    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory; 
    }*/
    public Inventory inventoryOther;
    Player player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        Text InventoryText = GameObject.Find("Canvas/PokeBall/Text").GetComponent<Text>();
        Text InventoryText2 = GameObject.Find("Canvas/PokeBall/Text2").GetComponent<Text>();
        bool placeholder = true; // <= temporary placeholder, change to a bool check that checks if the player has pokeballs in their inventory 
        //inventoryOther.addItem(new Item { itemType = Item.ItemType.Pokeball, amount = 1 }); //For testing, inventory needs to come from BagInventory
        if (placeholder == true) {
            InventoryText.text = "PocketBall    x" + player.getnumPokeBall();
            InventoryText2.text = "Potion    x" + player.getnumPotion();
            //InventoryText.text = "Pokeball    x3"; // Place holder
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
