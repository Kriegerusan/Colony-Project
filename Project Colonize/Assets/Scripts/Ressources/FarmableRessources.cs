using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmableRessources : Destructible
{

    [SerializeField] LootTable lootTable;

    public override void Repair(int amount)
    {
        
    }

    public override void TakeDamage(int amount, string source)
    {
        health -= amount;
        if(health <= 0)
        {
            health = 0;
            foreach(Loot loot in lootTable.Loots)
            {
                if(Random.Range(0,100f) <= loot.chanceToDrop)
                {
                    int lootAmount = Random.Range(loot.minAmount, loot.maxAmount + 1);
                    for (int i = 0; i < lootAmount ; i++)
                    {
                        Debug.Log($"Spawning : {loot.name} \n Amount : {lootAmount}");
                        Instantiate(loot.prefab, transform.position, Quaternion.identity);
                    }
                }
            }
            Destroy(gameObject);
        }
    }
}
