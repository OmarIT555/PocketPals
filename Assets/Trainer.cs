using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trainer : MonoBehaviour
{
    public GameObject sign;
    public List<OwnedPokemon> ownedPokemon = new List<OwnedPokemon>();
    private GameManager gm;
    public Text signText;
    public Sprite gymLeader;
    public string introBattleText;
    public string introText;
    public string defeatText;
    public bool active;
    public bool beaten;
    public int ID;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        beaten = false;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonDown("Fire1") && active && gm.getBattleType() == 0)
        {


            if (sign.activeInHierarchy && beaten == false)
            {
                sign.SetActive(false);
                gm.setBattleType(3);
                gm.setTrainer(ID);
                gm.EnterBattle();
            }
            else
            {
                sign.SetActive(true);
                if (beaten == false)
                {
                    signText.text = introText;
                }
                else
                {
                    signText.text = defeatText;
                }


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

    public String getIntro()
    {
        return introBattleText;
    }


    public Sprite getGymLeader()
    {
        return gymLeader;
    }

    public void setBeaten(bool temp)
    {
        beaten = temp;
    }

    public int getTrainerID()
    {
        return ID;
    }

}
