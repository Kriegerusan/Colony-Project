using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class Loot
{
    public string name;

    public GameObject prefab;

    //random.range(0,100f) <= CTD
    [Range(0,100)]
    public float chanceToDrop;
    
    // Value > 0 !
    [Range(1,250)]
    public int minAmount = 1, maxAmount = 1;
    
}

[CreateAssetMenu(fileName = "New Loot Table", menuName = "Loot Table")]
public class LootTable : ScriptableObject
{
    [SerializeField] Loot[] loots;
    public Loot[] Loots { get { return loots; }}
}
