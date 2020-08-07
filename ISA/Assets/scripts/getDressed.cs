using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class getDressed : MonoBehaviour
{
    public GameObject tie;
    public bool getChanged = false;
    public bool dressed = false;
    public loadScene load;
    private Animator anim;
    public leaveRoom enter;
    public GameObject work;
    public GameObject dress;
    public AudioSource open;
    private Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        anim = GetComponent<Animator>();
        if (scene.name == "goSleep")
        {
            dressed = true;
            if (work != null && load.sceneNum == 1)
            {
                work.SetActive(true);
            }
        }

    }

    void OnMouseDown()
    {
        if (getChanged && anim != null)
        {
            if (!dressed)
            {
                anim.enabled = true;
                dressed = true;
            }
            else if (enter != null && dressed &&  enter.entered)
            {
                anim.enabled = true;
                dressed = false;
            }
        }

    }

    void OnTriggerEnter (Collider other)
    {
        // check if enter panel
        if (other.name == "Player")
        {
            getChanged = true;
            if (dress != null && !dressed)
            {
                dress.SetActive(true);
            }
           
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.name == "Player")
        {
            getChanged = false;
            if (load.sceneNum == 1 && scene.name == "goSleep")
            {
                if (dress != null)
                {
                    dress.SetActive(true);
                }
                if (work != null)
                {
                    work.SetActive(false);
                }
            }
           
        }
    }

    void equipTie()
    {
        if (scene.name == "goSleep")
        {
            tie.SetActive(false);
        }
        else 
        {           
            tie.SetActive(true);
            if (work != null && dress != null)
            {
                dress.SetActive(false);
                work.SetActive(true);
            }
        }
    }

    void play()
    {
        open.Play();
    }
   
}
