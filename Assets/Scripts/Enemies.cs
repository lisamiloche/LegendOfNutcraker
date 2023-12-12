using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float speed;


    private void Start()
    {
        /*if (GameObject.Find("Player") != null)
        {
            int direction = 
        }*/
    }   


    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }


}
