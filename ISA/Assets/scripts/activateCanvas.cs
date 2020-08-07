using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateCanvas : MonoBehaviour
{
    public GameObject replay;

    void Awake()
    {
        loadScene.loadNum = 0;
    }

    void activate()
    {
        replay.SetActive(true);
        gameObject.SetActive(false);
    }
}
