using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnButton : MonoBehaviour
{
    public void returnButton()
    {
        SceneManager.LoadSceneAsync("OverWorld", LoadSceneMode.Single);
    }
}
