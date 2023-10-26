using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Destructible : MonoBehaviour
{

    [SerializeField] protected int maxHealth;
    protected int health;

    public abstract void TakeDamage(int amount, string source);

}
