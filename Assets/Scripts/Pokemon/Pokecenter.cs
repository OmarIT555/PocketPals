using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pokecenter : MonoBehaviour
{
    public Player player;
    public GameObject poke; 
    public Text speechText;
    public int playerFullHealth;
    public string text;
    public bool active;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        playerFullHealth = player.ownedPokemon[0].pokemon.FullHP;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1") && active)
        {


            if (poke.activeInHierarchy)
            {
                poke.SetActive(false);

            }
            else
            {
                for (int x = 0; x < player.ownedPokemon.Count; x++)
                {
                    player.ownedPokemon[x].pokemon.HP = (int)player.ownedPokemon[x].pokemon.FullHP;
                }
                poke.SetActive(true);
                speechText.text = text;

            }

        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            active = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            active = false;
            poke.SetActive(false);
        }
    }

}
