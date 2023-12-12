using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float speed = 3f;
    public float distance = 7f;

    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer < distance)
        {
            player.GetComponent<Player>().LaunchSpell(transform.position);
        }
    }


}
