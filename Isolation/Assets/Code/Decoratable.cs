using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decoratable : MonoBehaviour
{
    [SerializeField]
    public Vector3 point;

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(point, 0.1f);
    }
}
