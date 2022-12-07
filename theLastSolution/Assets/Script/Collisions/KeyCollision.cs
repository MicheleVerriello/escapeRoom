using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollision : MonoBehaviour
{

    public GameObject keyGame;
    public GameObject keyPlayer;
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
        keyGame.SetActive(false);
        keyPlayer.SetActive(true);
    }
}
