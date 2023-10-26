using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    //remplacer par weaponScript
    [SerializeField] private GameObject weaponSlot1, weaponSlot2, weaponSlot3;
    //remplacer par armorScript
    [SerializeField] private GameObject armorSlot1, armorSlot2, armorSlot3;
    //remplacer par itemScript
    [SerializeField] private List<GameObject> items = new List<GameObject>();
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
