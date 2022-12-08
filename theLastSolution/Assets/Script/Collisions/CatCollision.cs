using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCollision : MonoBehaviour
{
    public GameObject canvasDialog;

    private void OnTriggerEnter2D(Collider2D col)
    {
        canvasDialog.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        canvasDialog.SetActive(false);
    }
}
