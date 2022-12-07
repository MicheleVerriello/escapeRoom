using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider slider;
    public float FillSpeed = 0.5f;
    private float targetProgress = 1;
    public GameObject winningCanvas;
    public GameObject sceneToDestroy;
    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        IncrementProgress(0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetProgress)
        {
            slider.value += FillSpeed * Time.deltaTime;
        }

        if (slider.value >= 1f)
        {
            winningCanvas.SetActive(false);
            SceneManager.LoadSceneAsync("Scenes/Menu");
        }
    }

    //Add progress to the bar
    public void IncrementProgress(float newProgress)
    {
        slider.value += newProgress;
    }
}
