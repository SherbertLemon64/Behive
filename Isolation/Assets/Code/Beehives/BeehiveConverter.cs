using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeehiveConverter : Beehive
{
    int pollen = 0;

    public void UploadPollen(int amount) => pollen = pollen + amount > GameManager.ConverterPollenCapacity ? GameManager.ConverterPollenCapacity : pollen + amount;

    public int GetHoney()
    {
        int outputHoneyAmount = pollen / 12;
        pollen -= outputHoneyAmount * 12;
        pollen = Mathf.Clamp(pollen, 0, GameManager.ConverterPollenCapacity);
        return outputHoneyAmount;
    }
}
