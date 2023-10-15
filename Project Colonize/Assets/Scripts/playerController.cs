using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    [SerializeField] private Camera playerCamera;
    [SerializeField] private GameObject weaponPivot;
    [SerializeField] private SpriteRenderer playerSprite;
    [SerializeField] private float moveSpeed;

    private Vector2 mousePosition;
    private Vector2 moveDirection;


    private void Update()
    {
        //mouse coordinates
        mousePosition = playerCamera.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        //player direction
        moveDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;

    }

    private void FixedUpdate()
    {
        MoveControl();
    }

    private void LateUpdate()
    {
        //AimControl();
    }

    private void AimControl()
    {

        //Rotate Weapon Pivot to look at Mouse Position
        if(weaponPivot != null)
        {
            weaponPivot.transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg);
            
        }

        //Flip Player Sprite on X Axis
        if (playerSprite != null)
        {
            if (mousePosition.x < 0)
            {
                playerSprite.flipX = true;
            }
            else
            {
                playerSprite.flipX = false;
            }
        }

    }

    private void MoveControl()
    {
        transform.Translate(moveDirection);
    }


}
