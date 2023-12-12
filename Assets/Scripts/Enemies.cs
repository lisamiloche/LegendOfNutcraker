using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float speed;
    public int enemyLife;
    public int enemyDamage;


    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

}