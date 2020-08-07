using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holdDown : MonoBehaviour
{
    private Vector3 jointPos;
    public GameObject target;

    void Start()
    {
        jointPos = target.transform.position;
        gameObject.transform.position = jointPos;
    }

}
