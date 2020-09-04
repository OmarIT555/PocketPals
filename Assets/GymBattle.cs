using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GymBattle : MonoBehaviour
{
    public GameObject sign;
    public List<OwnedPokemon> ownedPokemon = new List<OwnedPokemon>();
    private GameManager gm;
    public Text signText;
    public string text;
    public bool active;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonDown("Fire1") && active)
        {


            if (sign.activeInHierarchy)
            {
                sign.SetActive(false);
                gm.setBattleType(1);
                gm.EnterBattle();
            }
            else
            {
                sign.SetActive(true);
                signText.text = text;

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
            sign.SetActive(false);
        }
    }

    [System.Serializable]
    public class OwnedPokemon
    {
        public string NickName;

        //do not serailize this field, instead load it with ID
        // [System.NonSerialized] public BasePokemon pokemon; 
        // [System.NonSerialized]
        public BasePokemon pokemon;
        // pokemon = 
        // public int health = pokemon.HP;
        public int basePokemonID;


        public List<PokemonMoves> moves = new List<PokemonMoves>();

        public override string ToString()
        {
            string s = NickName + " PokID: " + basePokemonID;

            foreach (PokemonMoves pm in moves)
            {
                s += ", " + pm;
            }
            return s;
        }
    }
}
