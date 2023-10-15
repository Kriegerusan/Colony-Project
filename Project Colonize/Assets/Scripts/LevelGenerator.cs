using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    [SerializeField] bool lockRatio;
    [SerializeField] Vector2Int dimension;
    Vector2Int dimOffset;
    [SerializeField] GameObject iterator;
    [SerializeField] GameObject tile;

    private void Awake()
    {
        dimOffset = new Vector2Int(dimension.x / 2, dimension.y / 2);
        if (lockRatio)
        {
            dimension.y = dimension.x;
        }
    }

    private void Start()
    {
        GenerateFirstLayer();
    }

    private void GenerateFirstLayer()
    {
        /* Etape 1:
         * Generation de la grille selon paramettre
         */
        for(int i = -dimOffset.x; i < dimOffset.x; i++)
        {
            for(int j = -dimOffset.y; j < dimOffset.y; j++)
            {
                Instantiate(tile, new Vector3Int(i,j), quaternion.identity, transform);
            }
        }




         /* Etape 2:
         * 
        */
    }


}
