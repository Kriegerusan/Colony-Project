using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessourcesProps : Destructible
{

    [SerializeField] private GameObject itemToSpawn;

    private void Start()
    {
        Initialise();
    }

    public override void Repair(int amount)
    {
        
    }

    public override void TakeDamage(int amount, string source)
    {
        health -= amount;
        if(health <= 0)
        {
            health = 0;
            //destroy gameobject n instantiate item.
            Instantiate(itemToSpawn, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }


}
