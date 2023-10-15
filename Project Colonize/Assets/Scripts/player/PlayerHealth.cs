using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] int maxHealth;
    private int health;




    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    private void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            Debug.Log("Caracter's" + transform.parent.name + " dead");
        }
    }

    private void Heal(int amount)
    {
        health += amount;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }


}
