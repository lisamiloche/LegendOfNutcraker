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
            
            enemies.enemyLife--;
            Debug.Log(enemies.enemyLife);

        }
    }

    public void Direction()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

}
