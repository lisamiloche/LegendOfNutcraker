using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public void OnClickPlay()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void OnClickCredit()
    {
        SceneManager.LoadScene("Credits");
    }

    public void OnClickQuit()
    {
        Application.Quit();
    }

    public void OnClickBack()
    {
        SceneManager.LoadScene(0);
    }
}
