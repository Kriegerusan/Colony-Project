using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapon Data", fileName = "New Weapon Data")]
public class Weapon_Data : ScriptableObject
{
    public Sprite itemVisual, weaponVisual;
    public Vector2 transformOffset;

}
