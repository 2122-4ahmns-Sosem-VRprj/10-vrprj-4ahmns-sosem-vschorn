using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUi : MonoBehaviour
{
    private TextMeshProUGUI eggText;

    void Start()
    {
        eggText = GetComponent<TextMeshProUGUI>();
    }
    public void UpdateDiamondText(PlayerInventorySECOND playerInventorySECOND)
    {
        eggText.text = playerInventorySECOND.NumberOfEggs.ToString();
    }
    
}
