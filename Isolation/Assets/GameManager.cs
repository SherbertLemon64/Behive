using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
    static GameObject 


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
