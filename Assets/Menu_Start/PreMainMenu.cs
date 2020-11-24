using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PreMainMenu : MonoBehaviour
{
    Text title;

    public void StartButton()
    {
        SceneManager.LoadScene("Menu_Start");
    }


}
