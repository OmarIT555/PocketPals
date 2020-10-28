using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad;
    public Vector2 playerPosition;
    public VectorValue playerStorage;
    public GameObject player;
    public bool active;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            player.transform.position = new Vector3(playerPosition.x, playerPosition.y, 0);
            // playerStorage.initialValue = playerPosition;
            // SceneManager.LoadScene(sceneToLoad);
            SceneManager.LoadSceneAsync(sceneToLoad, LoadSceneMode.Additive);
        }
   
    }

 

}
