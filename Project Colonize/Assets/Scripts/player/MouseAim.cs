using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAim : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    private Vector2 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mouse coordinates
        mousePosition = playerCamera.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    }

    private void LateUpdate()
    {
        //Rotate Weapon Pivot to look at Mouse Position
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg);
    }
}
