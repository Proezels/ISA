using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class getUp : MonoBehaviour
{
    public int mouseClicks = 0;
    public GameObject cube;
    public GameObject sleepy;
    public int maxClicks = 10;
    public int maxSec = 5;
    public int maxTime = 30;
    private float timer = 0.0f;
    public int clicksTimer = 0;
    public int seconds = 0;
    public GameObject giveUp;
    public progress bar;
    public timer timeBar;
    private bool wakeUp = true;
    private bool success = false;


    void Start()
    {
        // makes bars sync with amount set
        bar.setMaxProgress(maxClicks);
        timeBar.setMaxtime(maxTime);
    }


    void Update()
    {
        // makes bar go up/down 
        bar.setProgress(mouseClicks);
        timeBar.settime(seconds);

        clicksTimer = clicksTimer + 1;
        
        //sets timer to start && converts into seconds
        if (success == false)
        {
            timer += Time.deltaTime;
            seconds = (int)(timer % 60);
        }

        //gameover when time runs out
        if (seconds >= maxTime)
        {
            SceneManager.LoadScene("GameOver");
            wakeUp = false;
        }

        if (seconds == 10f)
        {
            if (giveUp != null)
            {
                giveUp.SetActive(true);
            }
        }

        //wakes you up
        if (wakeUp == true)
        {
            if (mouseClicks == maxClicks)
            {
                cube.SetActive(true);
                sleepy.SetActive(false);
                bar.gameObject.SetActive(false);
                timeBar.gameObject.SetActive(false);
            }
            
            //counter clicks
            if (clicksTimer == maxSec)
            {
                clicksTimer = 0;
                if (mouseClicks >= 0 && mouseClicks < maxClicks)
                {
                    mouseClicks = mouseClicks - 1;
                }
                
            }
            //makes sure mouseclicks dont go into neg
            if (mouseClicks < 0)
            {
                mouseClicks = 0;
            }
            
            // activates wakeup sequence
            if (mouseClicks == maxClicks)
            {
                success = true;
            }
        }
        
    }

//check for clicking and add clicks to mouseclicks
    void OnMouseDown()
    {
        if (mouseClicks < maxClicks && wakeUp == true)
        {
            mouseClicks = mouseClicks + 1;
        }
    }

}
