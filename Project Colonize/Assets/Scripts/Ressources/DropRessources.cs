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

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        isProtected = true;
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

        if (!isProtected && nearestPlayerMagnitude <= detectionRadius)
        {
            MoveToNearestPlayer();
        }
    }

    private void FixedUpdate()
    {
        FindNearestPlayer();
    }

    void MoveToNearestPlayer()
    {
        rb.velocity = (nearestPlayer.transform.position - transform.position).normalized * moveSpeed;
    }

    void FindNearestPlayer()
    {
        foreach(playerController player in FindObjectsOfType<playerController>())
        {
            if (nearestPlayer == null)
            {
                nearestPlayer = player.gameObject;
                nearestPlayerMagnitude = (player.gameObject.transform.position - gameObject.transform.position).magnitude;
            }
            else
            {
                if (player.gameObject.transform.position.magnitude < nearestPlayerMagnitude)
                {
                    nearestPlayer = player.gameObject;
                    nearestPlayerMagnitude = (player.gameObject.transform.position - gameObject.transform.position).magnitude;
                }
            }
        }
    }




}
