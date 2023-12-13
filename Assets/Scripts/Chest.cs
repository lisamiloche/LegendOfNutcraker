using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    MainGame game;

    private void Start()
    {
        game = FindFirstObjectByType<MainGame>();
    }
    public void OnClickGet()
    {
        game.Money += 100;
        game.PopUp.SetActive(false);
        game.timePopUp = 0;
    }
}
