using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasbullaCollision : MonoBehaviour
{

    public GameObject canvasDialog;
    public GameObject keys;

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
