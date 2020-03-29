using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    void Start()
    {
        GameObject q = Instantiate(DecoDatabase.treeTrunks[0].gameObject, transform);
        Instantiate(DecoDatabase.treeTops[0].gameObject, transform.position + q.GetComponent<Decoratable>().point, Quaternion.identity, q.transform);
    }
}
