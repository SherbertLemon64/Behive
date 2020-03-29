using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour, IEntity
{
    public bool HasPollen;
    public void BeehiveInitialized(Beehive hive) { }
}
