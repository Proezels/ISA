using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterRoom : MonoBehaviour
{
    private Animator anim;
    public bool entered = false;
    private bool doorClose = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


        void OnTriggerExit (Collider other)
    {
        if (other.name == "Player" && !doorClose)
        {
            anim.SetTrigger("exit");
            doorClose = true;
        }
    }

    void enter()
    {
        entered = true;
    }
}
