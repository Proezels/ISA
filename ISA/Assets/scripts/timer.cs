using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Slider slider;

    
    public void setMaxtime(int time)
    {
        slider.maxValue = time;
        slider.value = time;
    }

    public void settime(int time)
    {
        slider.value = time;
    }

}
