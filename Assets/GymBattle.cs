using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GymBattle : MonoBehaviour
{
    public GameObject sign;
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
}
