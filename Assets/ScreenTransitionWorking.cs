using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionWorking : MonoBehaviour
{
    public string sceneToLoad;
    public Vector2 playerPosition;
    public VectorValue playerStorage;
    public GameObject player;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            player = GameObject.FindGameObjectWithTag("Player");
           // playerStorage.initialValue = playerPosition;
            SceneManager.LoadScene(sceneToLoad);
            player.transform.position = new Vector3(playerPosition.x, playerPosition.y, 0);
            //SceneManager.LoadSceneAsync(sceneToLoad, LoadSceneMode.Additive);
        }
    }

}
