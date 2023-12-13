using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Spell : MonoBehaviour
{

    
    public GameObject spellPrefab;
    public GameObject Enemy;
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
        if (col.gameObject.name == "Enemy")
        {
            Destroy(spellPrefab);

            enemies = GameObject.Find("Enemy").GetComponent<Enemies>();
            Damage = mainGame.PowerUps[0].Damage;
            enemies.enemyLife-= (int) Damage;
            Debug.Log(enemies.enemyLife);

        }
    }

    public void Direction()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

}
