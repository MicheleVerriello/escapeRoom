using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestCollision : MonoBehaviour
{
    public GameObject key;
    public GameObject chestCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        Debug.Log("key " + key.name);
        Debug.Log("chestCanvas " + chestCanvas.name);
        if (key.activeSelf)
        {
            chestCanvas.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {

        Debug.Log("key " + key.name);
        Debug.Log("chestCanvas " + chestCanvas.name);
        if (key.activeSelf)
        {
            chestCanvas.SetActive(false);
        }
    }
}
