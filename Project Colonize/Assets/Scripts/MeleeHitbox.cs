using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeHitbox : MonoBehaviour
{

    [SerializeField] private Collider2D hitboxCollider;

    private void Awake()
    {
        hitboxCollider = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ressources")
        {
            Debug.Log($"hit {collision.name}");
            collision.GetComponent<Destructible>().TakeDamage(this.GetComponentInParent<ToolBehaviour>().Damages,"null");
        }
    }
}
