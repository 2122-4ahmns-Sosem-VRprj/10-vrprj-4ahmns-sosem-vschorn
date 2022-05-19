using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

// https://www.youtube.com/watch?v=gAz_SeDUQBk 

public class Slot : MonoBehaviour
{
    public GameObject ItemInSlot;
    public Image slotImage;
    Color originalColor;

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


    void Start()
    {
        slotImage = GetComponentInChildren<Image>();
        originalColor = slotImage.color;
    }

    private void OnTriggerStay(Collider other)
    {
        if (ItemInSlot != null) return;
        GameObject obj = other.gameObject;
        if (!IsItem(obj)) return;
        if (m_LeftBaseController is XRGrabInteractable)
                {
            InsertItem(obj);
        }
    }

    bool IsItem(GameObject obj)
    {
        return obj.GetComponent<ite>();
    }

    void InsertItem(GameObject obj)
    {
        obj.GetComponent<Rigidbody>().isKinematic = true;
        obj.transform.SetParent(gameObject.transform, true);
        obj.transform.localPosition = Vector3.zero;
        obj.transform.localEulerAngles = obj.GetComponent<ite>().slotRotation;
        obj.GetComponent<ite>().inSlot = true;
        obj.GetComponent<ite>().currentSlot = this;
        ItemInSlot = obj;
        slotImage.color = Color.gray;
    }

    public void ResetColor()
    {
        slotImage.color = originalColor;
    }
}


