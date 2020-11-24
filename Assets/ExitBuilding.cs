using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitBuilding : MonoBehaviour
{
    GameObject player;
    public Vector2 vector;
    public string unload;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.transform.position = new Vector3(vector.x, vector.y, 0);
            SceneManager.UnloadSceneAsync(unload);

        }
    }
}
