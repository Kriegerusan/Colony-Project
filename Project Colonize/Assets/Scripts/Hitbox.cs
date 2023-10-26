using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{

    [SerializeField] private string collisionTag;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == collisionTag)
        {
            transform.GetComponentInParent<Destructible>().TakeDamage(1,collision.name);
        }
    }
}
