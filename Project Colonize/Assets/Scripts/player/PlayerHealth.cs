using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Destructible
{

    [SerializeField] int maxHunger, maxThirst;
    private int hunger, thirst;
    [SerializeField] float hungerIncreaseRate, thirstIncreaseRate;


    void Start()
    {
        Respawn();
    }

    //prendre des degats
    public override void TakeDamage(int amount, string source)
    {
        health -= amount;
        if(health <= 0)
        {
            Debug.Log("Caracter's" + transform.parent.name + " dead");
        }
    }


    //se soigner
    private void Heal(int amount)
    {
        health += amount;
    }

    //avoir faim
    private IEnumerator FoodDecreaseCoroutine()
    {
        yield return new WaitForSeconds(hungerIncreaseRate);
        if(hunger > 0)
        {
            hunger--;
        }
        else
        {
            TakeDamage(1, "Hunger");
        }
        StartCoroutine(FoodDecreaseCoroutine());

    }



    //se nourrir
    private void FoodIncrease()
    {

    }

    //se deshydrater
    private IEnumerator WaterDecreaseCoroutine()
    {
        yield return new WaitForSeconds(thirstIncreaseRate);
        if(thirst > 0)
        {
            thirst--;
        }
        else
        {
            TakeDamage(1, "Thirst");
        }
        StartCoroutine(WaterDecreaseCoroutine());
    }

    //s'hydrater
    private void WaterIncrease()
    {

    }

    private IEnumerator WaterIncreaseCoroutine()
    {
        yield return new WaitForSeconds(1f);
    }

    private void Respawn()
    {
        health = maxHealth;
        hunger = maxHunger;
        thirst = maxThirst;
    }

}
