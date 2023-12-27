using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Destructible : MonoBehaviour
{

    [SerializeField] protected int maxHealth;
    protected int health;

    protected void Initialise()
    {
        health = maxHealth;
    }

    public abstract void TakeDamage(int amount, string source);
    public abstract void Repair(int amount);
}
