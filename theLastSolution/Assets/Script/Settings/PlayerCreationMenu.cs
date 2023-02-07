using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

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
        //bool prefabSuccess;
        //PrefabUtility.SaveAsPrefabAsset(player, "Assets/Resources/Player.prefab", out prefabSuccess);
        //if (prefabSuccess == true)
            //Debug.Log("Prefab was saved successfully");
        //else
           // Debug.Log("Prefab failed to save" + prefabSuccess);

    }
}
