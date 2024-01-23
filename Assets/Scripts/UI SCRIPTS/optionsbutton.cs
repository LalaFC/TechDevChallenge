using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class optionsbutton : MonoBehaviour
{
    public string nextSceneName;
    public float fadeDuration = 1.0f;
    public int sceneID;

    public void ChangeSceneWithFade()
    {
        // Fade out
        DOTween.ToAlpha(() => Camera.main.backgroundColor, color => Camera.main.backgroundColor = color, 0f, fadeDuration)
            .OnComplete(() =>
            {
                SceneManager.LoadScene(sceneID);
            });
    }
}