using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    [SerializeField] private Transform parentTransform;
    void Update()
    {
        transform.position = new Vector3(parentTransform.position.x,0,(parentTransform.position.z-0.75f));
    }
}
