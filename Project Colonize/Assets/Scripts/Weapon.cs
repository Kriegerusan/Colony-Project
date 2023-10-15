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
        transform.position = new Vector3(transform.position.x + weaponData.transformOffset.x,transform.position.y + weaponData.transformOffset.y);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void LateUpdate()
    {
        if (transform.parent.transform.eulerAngles.z >= 90 && transform.parent.transform.eulerAngles.z <= 270)
        {
            weaponSprite.flipY = true;
        }
        else
        {
            weaponSprite.flipY = false;
        }
        
    }

    public void FlipSprite(bool value)
    {
        weaponSprite.flipY = value;
    }


}
