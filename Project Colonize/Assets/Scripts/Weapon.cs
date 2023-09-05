using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Weapon_Data weaponData;

    private SpriteRenderer weaponSprite;

    private void Awake()
    {
        weaponSprite = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        weaponSprite.sprite = weaponData.weaponVisual;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FlipSprite(bool value)
    {
        weaponSprite.flipY = value;
    }


}
