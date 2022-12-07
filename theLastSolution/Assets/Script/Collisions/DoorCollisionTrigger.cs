using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollisionTrigger : MonoBehaviour
{

    public GameObject codeInputCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        codeInputCanvas.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collider2D)
    {
        codeInputCanvas.SetActive(false);
    }
}
