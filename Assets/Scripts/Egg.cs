using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventorySECOND playerInventorySECOND = other.GetComponent<PlayerInventorySECOND>();

        if (playerInventorySECOND != null)
        {
            playerInventorySECOND.EggCollected();
            gameObject.SetActive(false);
        }
    }
}
