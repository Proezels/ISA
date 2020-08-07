using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class progress : MonoBehaviour
{
    public Slider slider;

    
    public void setMaxProgress(int progress)
    {
        slider.maxValue = progress;
        slider.value = progress;
    }

    public void setProgress(int progress)
    {
        slider.value = progress;
    }

}
