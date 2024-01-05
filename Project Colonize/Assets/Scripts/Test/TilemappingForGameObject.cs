using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TilemappingForGameObject : MonoBehaviour
{
    public enum directionTile
    {
        North,
        NorthEast,
        East,
        SouthEast,
        South,
        SouthWest,
        West,
        NorthWest
    }
    directionTile checkDirection;

    List<TilemappingForGameObject> tileGameObject = new List<TilemappingForGameObject>();
    [SerializeField] GameObject colliderDetectorPrefab;


    private void OnDestroy()
    {
        
        foreach(TilemappingForGameObject tile in tileGameObject)
        {
            UpdateNeighboorsTiles();
        }
    }

    void UpdateNeighboorsTiles()
    {
        //modifie le sprite de la tile actuelle par rapport aux voisins
        switch(checkDirection)
        {
            case directionTile.North:
                //GameObject detector = Instantiate(colliderDetectorPrefab,)
                break;
        }
    }

}
