using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Destructible : MonoBehaviour
{

    [SerializeField] protected int maxHealth;
    
    [SerializeField] [Range(0, 100f)] protected float damageResistance;

    protected int health;
    //Ajout public currentHealth -> UI.

    protected void Initialise()
    {
        health = maxHealth;
    }

    public abstract void TakeDamage(int amount, string source);
    public abstract void Repair(int amount);


    public virtual void TakeDamageWithResistance(int amount)
    {
        int damages = Resitance(amount);
        health -= damages;
        Debug.Log($"Entity {transform.parent.name} has Taken : {damages} damages");
        if (health <= 0)
        {
            Debug.Log($"Entity {transform.parent.name} is dead");
            Destroy(gameObject);
        }
    }

    protected int Resitance(int damage) 
    {
        return Mathf.RoundToInt(damage - (damage * damageResistance) / 100);
    }
}
