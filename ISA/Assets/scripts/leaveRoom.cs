using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leaveRoom : MonoBehaviour
{
    private Animator anim;
    public getDressed tie;
    private Collider collider;
    private Scene scene;
    public bool entered = false;
    private bool doorClose = false;
    public GameObject fadeCanvas;
    private Animator fadeAnim;
    private bool timeToSleep = false;
    public GameObject arm;
    public movement mov;
    public AudioSource open;

    void Start()
    {
        anim = GetComponent<Animator>();
        collider = GetComponent<BoxCollider>();
        scene = SceneManager.GetActiveScene();
        fadeAnim = fadeCanvas.GetComponent<Animator>();
        if (scene.name == "goSleep")
        {
            timeToSleep = true;
        }
    }

    void OnMouseDown()
    {
        
        if (tie != null && tie.dressed == true && timeToSleep == false)
        {
            anim.enabled = true;
            collider.enabled = false;
            open.Play();
        }

    }
    
        void OnTriggerExit (Collider other)
    {
        
        if (other.name == "Player")
        {
            anim.SetTrigger("exit");  
        
            if (scene.name == "goSleep" && !doorClose)
            {
                doorClose = true;
                entered = true;
            }
            else if (arm != null && mov != null)
            {
                arm.SetActive(false);
                mov.counterSpeed = 0f;
            }
        }
    }

        void exitScene()
        {
            if (scene.name == "goSleep")
            {
                entered = true;
            }
            else 
            {
                fadeAnim.SetTrigger("fadeOut");
            }
        }

        void playSound()
        {
            open.Play();
        }
 
}
