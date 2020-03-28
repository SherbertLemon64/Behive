using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beehive : MonoBehaviour
{
    public GameObject instance
    {
        get
        {
            return transform.gameObject;
        }
    }

    public void Update() => Tick();

    public void Tick()
    {

    }
} 