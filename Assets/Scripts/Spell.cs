using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{

    public float speed = 5f;
    private Vector3 direction;

    void Start()
    {
        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = direction * speed;
    }

    public void SetDirection(Vector3 newDirection)
    {
        direction = newDirection;
    
    }


}
