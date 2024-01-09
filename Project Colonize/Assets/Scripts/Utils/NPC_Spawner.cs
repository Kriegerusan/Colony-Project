using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Spawner : MonoBehaviour
{
    [Header("General Properties")]
    [SerializeField] private bool isActive;
    [SerializeField] private GameObject npcPrefab;
    [SerializeField] private int npcInAction;
    [SerializeField] private float spawnRate;
    [SerializeField] private bool isLimited;
    [SerializeField] private int spawnLimitation;

    [Header("random spawner properties")]
    [SerializeField] private Vector2 xOffset;
    [SerializeField] private Vector2 yOffset;

    private int spawnCount;
    private Vector3 origin;
    private List<GameObject> childActor = new List<GameObject>();
    private Collider2D[] collidersBuffer = new Collider2D[1];
    private float timer;
    //private float coolDown;


    private void Start()
    {
        origin = transform.position;
        SetCountdown(spawnRate);
    }


    private void Update()
    {
        if (!isActive) { return; }
        
        if(Countdown() > 0)
        {
            Countdown();
        }

        if(Countdown() <= 0)
        {
            SpawnActor();
        }



    }



    private void SpawnActor()
    {

        SetCountdown(spawnRate);

        if (npcInAction > 0)
        {
            if(transform.childCount < npcInAction)
            {
                GameObject actor = Instantiate(npcPrefab, GetRandomSpawnPoint(), Quaternion.identity);
                actor.transform.SetParent(transform);
            }
            else { return; }
        }
        else
        {
            GameObject actor = Instantiate(npcPrefab, GetRandomSpawnPoint(), Quaternion.identity);
            actor.transform.SetParent(transform);
        }
        
        
        //childActor.Add(actor);
    }

    public void SetProperties()
    {
        //fonction externe de modification des parametres
    }

    public void SetActive(bool isActive)
    {
        this.isActive = isActive;
    }

    private Vector2 GetRandomSpawnPoint()
    {
        float x = 0;
        float y = 0;

        while (true)
        {
            Debug.LogWarning("randoming position");
            x = Random.Range(xOffset.x, xOffset.y);
            y = Random.Range(xOffset.x, yOffset.y);
            Vector2 spawnPoint = new Vector2(origin.x + x, origin.y + y);
            int numColliders = Physics2D.OverlapCircle(spawnPoint, .25f, default, collidersBuffer);
            Debug.Log(numColliders);
            if (numColliders == 0) { return spawnPoint; }
        }
    }

    float Countdown()
    {
        //Debug.Log(timer);
        if (timer <= 0)
        {
            return 0;
        }
        else { return timer -= Time.deltaTime; }
        
    }

    void SetCountdown(float value)
    {
        timer = value;
    }

}
