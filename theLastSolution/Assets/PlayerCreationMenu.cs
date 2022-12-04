using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;

public class PlayerCreationMenu : MonoBehaviour
{
    public GameObject player;
    public List<OutfitChanger> outfitChangers = new();

    public void RandomizePlayer()
    {
        foreach (OutfitChanger changer in outfitChangers)
        {
            changer.Randomize();
        }
    }

    public void Save()
    {
        //PrefabUtility.SaveAsPrefabAsset(player, "Assets/Player.prefab");
        SceneManager.LoadScene(0);
    }
}
