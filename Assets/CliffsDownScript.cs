using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CliffsDownScript : MonoBehaviour
{

    TilemapCollider2D E;
    Player p;

    // Start is called before the first frame update
    void Start()
    {
        E = GetComponent<TilemapCollider2D>();
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        playerJump();
        Debug.Log("Dennis");
    }

    void playerJump() { 
    
        if (E.IsTouching(p.GetComponent<Collider2D>()))
        {
            Debug.Log("jump could maybe work");
        }
    
    }


}
