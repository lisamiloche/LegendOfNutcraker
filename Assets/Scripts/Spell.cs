using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spell : MonoBehaviour
{

    public float speed;
    public GameObject spellPrefab;
    public GameObject Enemy;

    public void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Enemy")
        {
            //Debug.Log(col.gameObject.name);
            Destroy(spellPrefab);
        }
    }

}
