using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class Spell : MonoBehaviour
{


    public GameObject spellPrefab;
    public GameObject Enemy;
    public GameObject PowerUP;
    Enemies enemies;
    public int speed;
    public float TimerDeleteSpell;
    public float Damage;
    private MainGame mainGame;

    private void Start()
    {
        mainGame = FindFirstObjectByType<MainGame>();
    }


    public void Update()
    {
        Direction();
        TimerDeleteSpell--;
        if (TimerDeleteSpell <= 0)
        {
            Destroy(spellPrefab);
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            Destroy(spellPrefab);
            enemies = Enemy.GetComponent<Enemies>();

            if (col.TryGetComponent<Enemies>(out enemies))
            {
                Damage = mainGame.PowerUps[0].Value;
                enemies.enemyLife -= (int)Damage;
                Debug.Log(enemies.enemyLife);
            }

        }
    }

    public void Direction()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

}
