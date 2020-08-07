using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public CharacterController controller;
    public bool facingRight = true;
    public float speed = 6f;
    public float counterSpeed = 0f;
    public float backSpeed = 0f;
    public float forwardSpeed = 0f;
    public GameObject arm;
    public GameObject flipArm;
    private Scene scene;



    void Update()
    {

        scene = SceneManager.GetActiveScene();
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector3 direction = new Vector3(horizontal, 0f).normalized;
        Vector3 counterDirection = new Vector3(counterSpeed, 0f).normalized;

        //moves character
        if (direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        } 
        //countermoves character
        if (direction.magnitude == 0)
        {
            controller.Move(counterDirection * Time.deltaTime);
        }  
        // flips character when switching direction
        if (Input.GetAxis("Horizontal") > 0f && !facingRight)
        {
            flip();
        }        

        if (Input.GetAxis("Horizontal") < 0f && facingRight)
        {
            flip();
        }

        //applies counterforce
        if (scene.name == "goSleep" || scene.name == "getUp")
        {
            counterSpeed = 0f;
        }
        else 
        {
            if (!facingRight)
            {
                speed = backSpeed;
            }
            else
            {
                speed = forwardSpeed;
            }
        }

    }

    private void flip()
    {
        // flips character 
        facingRight = !facingRight;
        if (!facingRight)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            if (arm != null && flipArm != null)
            {
                arm.SetActive(false);
                flipArm.SetActive(true);
            }
        }
        else if (facingRight)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            if (arm != null && flipArm != null)
            {
                arm.SetActive(true);
                flipArm.SetActive(false);
            }
        }

    }
}
