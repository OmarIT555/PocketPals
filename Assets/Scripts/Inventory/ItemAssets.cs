using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }

    public void Start()
    {
        Instance = this;
    }


    public Transform pfPokeBall;

    public Sprite pokeball;


}
