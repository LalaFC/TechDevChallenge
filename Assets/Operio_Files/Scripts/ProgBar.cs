using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ProgBar : MonoBehaviour
{
    public int max;
    public int current;
    [Range (0,5)] public Image Mask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();
    }
    void GetCurrentFill()
    {
        float fill = (float)current / (float)max;
        Mask.fillAmount = fill;
    }
}
