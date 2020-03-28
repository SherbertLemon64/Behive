﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decorator : VoxelGen
{
    GameManager 


    private void Update() { }

    private void Start()
    {
        base.Start();
        Decorate();
    }

    void Decorate()
    {
        for(int j = 0; j < (bloacks.Count); j += 17 + Random.Range(0, 17))
        {
            try
            {
                Instantiate(bloacks[j], bloacks[j].transform.position + Vector3.up, Quaternion.identity);
            }
            catch
            {
                continue;
            }
        }
    }
}
