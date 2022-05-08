using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventorySECOND : MonoBehaviour
{
    public int NumberOfEggs { get; private set; }

    public UnityEvent<PlayerInventorySECOND> OnEggCollected;

    public void EggCollected()
    {
        NumberOfEggs++;
        OnEggCollected.Invoke(this);

    }
}
