using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject spellPrefab;
    public GameObject Enemy;
    public GameObject player;
    public int playerLife;


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Enemy")
        {
            playerLife--;
            Debug.Log(playerLife);
            //faire un timer pour que ça ne tue pas d'un seul coup
            if (playerLife <= 0 )
            {
                Destroy(player); //animation de mort
            }

        }
    }





}