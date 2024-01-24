using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostileBehaviour : Destructible
{

    private void Start()
    {
        health = maxHealth;
    }

    public override void Repair(int amount)
    {
        throw new System.NotImplementedException();
    }

    public override void TakeDamage(int amount, string source)
    {
        throw new System.NotImplementedException();
    }


}
