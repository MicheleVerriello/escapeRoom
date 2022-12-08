using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasbullaCollision : MonoBehaviour
{

    public GameObject canvasDialog;
    public GameObject keys;
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
        canvasDialog.SetActive(true);
        keys.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        canvasDialog.SetActive(false);
    }
}
