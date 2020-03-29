using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decorator : VoxelGen
{
    public Decoratable[] treeTops;
    public Decoratable[] treeTrunks;

    private void Awake()
    {
        DecoDatabase.treeTops = this.treeTops;
        DecoDatabase.treeTrunks = this.treeTrunks;
    }

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
                Instantiate(new GameObject().AddComponent<Tree>(), bloacks[j].transform.position, Quaternion.identity);
            }
            catch
            {
                continue;
            }
        }
    }
}

public static class DecoDatabase
{
    public static Decoratable[] treeTops;
    public static Decoratable[] treeTrunks;
}