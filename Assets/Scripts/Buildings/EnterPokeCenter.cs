﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterPokeCenter : MonoBehaviour
{
    public GameObject player;
    public bool active;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");




    }

    // Update is called once per frame
    void Update()
    {
        Scene home = SceneManager.GetSceneByName("");

        if (active && Input.GetButtonDown("Fire1"))
        {
            load("pokecenter_interior");


        }

    }

    public void load(string PlayerHome)
    {
        SceneManager.LoadScene("pokecenter_interior");
        SceneManager.UnloadSceneAsync("OverWorld");

    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            active = true;
            Debug.Log("active");

        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            active = false;
        }
    }
}

