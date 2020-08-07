using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goSleep : MonoBehaviour
{
    public GameObject sleepy;
    public GameObject player;
    public getDressed getDressed;
    public GameObject fadeCanvas;
    private Animator fadeAnim;
    private bool sleep = false;


    void Start()
    {
        fadeAnim = fadeCanvas.GetComponent<Animator>();
    }

    void Update()
    {
        if (sleep)
        {
            fadeAnim.SetTrigger("fadeOut");
        }
    }

    void OnMouseDown()
    {
        if (!getDressed.dressed)
        {
            sleepy.SetActive(true);
            player.SetActive(false);
            sleep = true;
        }
    }
}
