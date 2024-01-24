using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class playbutton : MonoBehaviour
{
    public GameObject Canvas;

    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    public void HideButtons()
    {
        Canvas.SetActive(false);
    }

}