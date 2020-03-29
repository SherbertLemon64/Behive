using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public static class GameManager
{
    // UPGRADEABLES
    public static int ConverterPollenCapacity = 12 * 6;

    public static BeehiveInit beehiveInit = new BeehiveInit();
    static uint _money;

    static public int Money
    {
        get
        {
            return (int)_money;
        }
        set
        {
            _money = (uint)Mathf.Abs(value);
        }
    }
}

public class BeehiveInit : UnityEvent<Beehive> { }