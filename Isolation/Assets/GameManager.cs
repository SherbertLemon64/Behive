using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public static class GameManager
{
    public static UnityEvent TICK;

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
