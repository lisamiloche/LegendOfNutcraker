using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float distance = 5f;
    public GameObject spellPrefab;

    void Update()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, distance);


        foreach (Collider2D collider in colliders)
        {

            if (collider.CompareTag("Enemy"))
            {
                LaunchSpell(collider.transform.position);
                break;
            }

        }


    }

    public void LaunchSpell(Vector3 targetPosition)
    {
        GameObject spellInstance = Instantiate(spellPrefab, transform.position, Quaternion.identity);
        Vector3 direction = (targetPosition - transform.position).normalized;
        spellInstance.GetComponent<Spell>().SetDirection(direction);

    }

}
