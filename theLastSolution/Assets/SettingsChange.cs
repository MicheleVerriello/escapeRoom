using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsChange : MonoBehaviour
{
    public void SetQuality (int qualityIndex)
    {    
        QualitySettings.SetQualityLevel(qualityIndex);
        Debug.Log(QualitySettings.GetQualityLevel());
        PlayerPrefs.SetInt("_qualityIndex", qualityIndex);
    }
}
