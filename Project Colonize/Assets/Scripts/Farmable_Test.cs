using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmable_Test : Destructible
{
    /*
     * Donnees requises:
     *  - Objet attribue au joueur lors degat au prop || destruction du prop
     *    joueur source / objet source? / degats
     *  - HP du prop
     *  - ???
     *  
     * Fonction:
     *  - TakeDamage(int amount)
     *  - 
     * 
     */

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public override void TakeDamage(int amount, string damageSource)
    {
        health -= amount;
        Debug.Log("degats a l'entite " + gameObject.name + "recu de : " + damageSource);
    }

    public override void Repair(int amount)
    {
        throw new System.NotImplementedException();
    }
}
