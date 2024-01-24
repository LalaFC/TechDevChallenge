using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public float timer;
    public TextMeshProUGUI displayTime;

    private float initialTime;

    private void Start()
    {
        initialTime = timer;
    }

    private void Update()
    {
        timeSet();
    }

    string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void timeSet()
    {
       if(timer > 0)
        {
            timer -= Time.deltaTime;
            displayTime.text = FormatTime(timer);

            if(timer <= 0)
            {
                Debug.Log("Game Over");
                SceneManager.LoadScene("LoseScene");
            }
        }
    }
}
