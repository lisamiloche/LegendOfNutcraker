using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    MainGame game;
    EnemySpawner spawner;
    private int moneyGain;

    private void Start()
    {
        game = FindFirstObjectByType<MainGame>();
        spawner = FindFirstObjectByType<EnemySpawner>();
    }
    public void OnClickGet()
    {
        game.Money += 100;
        spawner.isBossDead = false;
        game.PopUp.SetActive(false);
    }
}
