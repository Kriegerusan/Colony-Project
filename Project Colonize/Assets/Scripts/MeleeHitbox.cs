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
        if(collision.tag == "Hitbox")
        {
            Debug.Log($"hit {collision.transform.parent}");
            collision.GetComponentInParent<Destructible>().TakeDamageWithResistance(this.GetComponentInParent<ToolBehaviour>().Damages);
        }
    }
}
