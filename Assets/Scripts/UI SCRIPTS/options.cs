using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class options : MonoBehaviour
{
    public void setVolume (float volume)
    {
        Debug.Log(volume);
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
