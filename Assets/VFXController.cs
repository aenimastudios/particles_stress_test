using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.UI;

public class VFXController : MonoBehaviour
{

    public Slider slider;
    public VisualEffect effect;	

    public void ApplyUpdate()
    {
        effect.SetInt("rate", (int)slider.value);   
    }
}
