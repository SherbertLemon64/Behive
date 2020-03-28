using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShopper : MonoBehaviour
{
    public Beehive ActiveItem;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Place(ActiveItem);
        }
    }

    public void Place(Beehive item)
    {
        Instantiate(ActiveItem.instance, transform.position, Quaternion.identity);
    }
}
