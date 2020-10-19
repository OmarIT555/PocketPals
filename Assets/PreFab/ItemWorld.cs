using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Item in a world script
 * 
 */


public class ItemWorld : MonoBehaviour
{
    
    public static ItemWorld spawnPokeBall(Vector3 position, Item item)
    {
        Transform transform = Instantiate(ItemAssets.Instance.pfPokeBall, position, Quaternion.identity);

        ItemWorld pokeball = transform.GetComponent<ItemWorld>();
        pokeball.SetItem(item);

        return pokeball;
    }

    public Item item;
    public SpriteRenderer spriteRenderer;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    public void SetItem(Item item)
    {
        this.item = item;
        spriteRenderer.sprite = item.getSprite();
    }

    public Item getItem()
    {
        return item;
    }

    public void destroySelf()
    {
        Destroy(gameObject);
    }
}
