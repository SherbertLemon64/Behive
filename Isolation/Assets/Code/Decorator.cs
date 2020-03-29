using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decorator : VoxelGen
{
    private void Start()
    {
        base.Start();
        Decorate();
    }

    void Decorate()
    {
        for(int j = 0; j < (bloacks.Count); j += 14 + Random.Range(0, 14))
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
