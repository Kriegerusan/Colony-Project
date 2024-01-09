using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class DropRessources : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1.5f;
    
    [SerializeField] float detectionRadius = 1;

    [SerializeField] float spawnCooldown = 1f;

    Rigidbody2D rb;
    bool isProtected;
    GameObject nearestPlayer;
    float nearestPlayerMagnitude;
    //GameObject selectedPlayer;
    float detectionRadiusSqrt;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        isProtected = true;
        detectionRadiusSqrt = MathF.Sqrt(detectionRadius);
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnCooldown > 0 && isProtected)
        {
            spawnCooldown -= Time.deltaTime;
            if(spawnCooldown <= 0)
            {
                isProtected = false;
            }
        }

        if (!isProtected)
        {
            if(GetPlayerDistance(nearestPlayer.transform.position) <= detectionRadiusSqrt)
            {
                MoveToNearestPlayer(true);
            }else
            {
                MoveToNearestPlayer(false);
            }
            

        }

    }

    private void FixedUpdate()
    {
        FindNearestPlayer();
    }

    void MoveToNearestPlayer(bool active)
    {
        if (active)
        {
            rb.velocity = (nearestPlayer.transform.position - transform.position).normalized * moveSpeed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
        
    }

    void FindNearestPlayer()
    {
        //a remplacer par OnTriggerEnter et OnTriggerExit !
        foreach(playerController player in FindObjectsOfType<playerController>())
        {
            if (nearestPlayer == null)
            {
                nearestPlayer = player.gameObject;
                nearestPlayerMagnitude = GetPlayerDistance(player.transform.position);
            }
            else
            {
                if (GetPlayerDistance(player.transform.position) < nearestPlayerMagnitude)
                {
                    nearestPlayer = player.gameObject;
                }
                else { return; }
            }
        }
    }

    float GetPlayerDistance(Vector2 target)
    {
        float magnitude = (target - (Vector2)transform.position).sqrMagnitude;
        return magnitude;
    }




}
