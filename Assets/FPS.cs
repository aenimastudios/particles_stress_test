using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class FPS : MonoBehaviour
{
    public Text ms;
    public Text fps;
    public Text rate;
    public Text particles;
    public Slider slider;
    public VisualEffect effect;

    void Start(){
        Application.targetFrameRate = 300;
    }

    void Update()
    {
        ms.text = (Time.deltaTime * 1000f).ToString("000.00") + " ms";
        fps.text = (1f / Time.deltaTime).ToString("00.00") + " fps";
        rate.text = slider.value.ToString() + " particles/sec";
        particles.text = effect.aliveParticleCount.ToString() + " total particles";
    }
}
