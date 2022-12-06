using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SpriteLoader : MonoBehaviour
{
    public GameObject playerToLoad;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Loading player");
        playerToLoad = PrefabUtility.LoadPrefabContents("Assets/Resources/Player.prefab");
    }
}