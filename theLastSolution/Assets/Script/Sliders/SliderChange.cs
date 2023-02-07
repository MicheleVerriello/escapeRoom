using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderChange : MonoBehaviour
{
    public Slider volumeSlider;

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
    }
}
