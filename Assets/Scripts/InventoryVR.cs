using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryVR : MonoBehaviour
{
    public GameObject Inventory;
    public GameObject Anchor;
    bool UIActive;

    [SerializeField]
    [Tooltip("The Game Object which represents the left hand for normal interaction purposes.")]
    GameObject m_LeftBaseController;
    /// <summary>
    /// The Game Object which represents the left hand for normal interaction purposes.
    /// </summary>
    public GameObject leftBaseController
    {
        get => m_LeftBaseController;
        set => m_LeftBaseController = value;
    }

    private void Start()
    {
        Inventory.SetActive(false);
        UIActive = false;
    }

    [System.Obsolete]
    private void Update()
    {
        if (m_LeftBaseController.active)
        {
            UIActive = !UIActive;
            Inventory.SetActive(UIActive);
        }
        if (UIActive)
        {
            Inventory.transform.position = Anchor.transform.position;
            Inventory.transform.eulerAngles = new Vector3(Anchor.transform.eulerAngles.x + 15, Anchor.transform.eulerAngles.y, 0);
        }
    }
}
