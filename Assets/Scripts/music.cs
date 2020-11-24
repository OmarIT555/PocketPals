using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class music : MonoBehaviour
{

    public AudioSource BGM;

    void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        BGM = this.GetComponent<AudioSource>();
        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

    }

    public void ChangeBGM(AudioClip music)
    {
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }
    
}
