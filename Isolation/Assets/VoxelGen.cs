using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoxelGen : MonoBehaviour
{
    public float freq = 1f;
    public float amp = 20f;
    public GameObject CurrentBlockType;
    public List<GameObject> bloacks = new List<GameObject>();
    public List<Vector3> blockTransform = new List<Vector3>();


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
        float cols = 40f;
        float rows = 40f;

        for(float x = 0; x < cols; x++)
        {
            
            for (float z = 0; z < rows; z++)
            {
                float y = Mathf.PerlinNoise(x/(cols * freq), z/(rows * freq)) * amp;
                blockTransform.Add(new Vector3(x,y,z));
            }
        }
        int index = 0;
        for (float x = 0; x < cols; x++)
        {
            for (float z = 0; z < rows; z++)
            {
                GameObject InsBlock = GameObject.Instantiate(CurrentBlockType);
                InsBlock.transform.position = blockTransform[index];
                for (int i = 0; i < 5; i++)
                {
                    // return for how many sides are next to and where
                }
                bloacks.Add(InsBlock);
                index++;
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
