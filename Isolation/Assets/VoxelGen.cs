using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoxelGen : MonoBehaviour
{
    public float freq = 1f;
    public float amp = 20f;
    public GameObject CurrentBlockType;
    public List<GameObject> bloacks = new List<GameObject>();


    void Start()
    {
        GenerateTerrain();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log(1);
            KillTerrain();
            
        }
    }

    void GenerateTerrain()
    {
        float cols = 20f;
        float rows = 20f;

        for(float x = 0; x < cols; x++)
        {
            
            for (float z = 0; z < rows; z++)
            {
                float y = Mathf.PerlinNoise(x/(cols * freq), z/(rows * freq)) * amp;
                GameObject InsBlock = GameObject.Instantiate(CurrentBlockType);
                InsBlock.transform.position = new Vector3(x, y, z);
                bloacks.Add(InsBlock);
            }
        }
    }

    void KillTerrain ()
    {
        for (int i = bloacks.Count - 1; bloacks.Count > 0; i--)
        {
            Destroy(bloacks[i]);
            bloacks.RemoveAt(i);
        }
        GenerateTerrain();
    }

    
}
