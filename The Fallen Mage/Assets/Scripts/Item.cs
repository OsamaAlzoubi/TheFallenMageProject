using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] private string Name;

    public string getName()
    {
        return Name;
    }
}
