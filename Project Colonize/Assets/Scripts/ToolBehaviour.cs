using Mirror;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToolBehaviour : MonoBehaviour
{

    [SerializeField] private GameObject hitbox;

    [SerializeField] private float useCooldown;
    [field: SerializeField] public int Damages { get; private set; }

    private float timer;
    private bool cooldownCoroutine;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !cooldownCoroutine)
        {
            StartCoroutine(ChopCoroutine());
        }
    }

    private IEnumerator ChopCoroutine()
    {
        cooldownCoroutine = true;
        hitbox.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        hitbox.SetActive(false);
        yield return new WaitForSeconds(useCooldown);
        cooldownCoroutine = false;
    }
}
