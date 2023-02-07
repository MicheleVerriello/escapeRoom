using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AudioControls : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicObjects = GameObject.FindGameObjectsWithTag("GameMusic");

        if (musicObjects.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
