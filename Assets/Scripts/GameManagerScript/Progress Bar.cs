using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] float max = 5;
    public Image PlayerBarFill, EnemyBarFill;
    public int playerScore, enemyScore;
    public float percentP, percentE;
    private void Start()
    {
        PlayerBarFill = gameManager.instance.PlayerBar.GetComponent<Image>();
        EnemyBarFill = gameManager.instance.EnemyBar.GetComponent<Image>();
    }
    private void Update()
    {
        playerScore = gameManager.instance.ScoreCounter.PlayerMaterialCounter;
        enemyScore = gameManager.instance.ScoreCounter.EnemyMaterialCounter;
        changePlayerScore();
        changeEnemyScore();
    }
    private void changePlayerScore()
    {
        UpdatePlayerScore();
        percentP = ( (float)playerScore/ max);
        gameManager.instance.PlayerBar.GetComponent<Image>().fillAmount = percentP;
    }
    void UpdatePlayerScore()
    {
        gameManager.instance.playerScoreTxt.text = playerScore.ToString() + '/' + max.ToString();
    }
    private void changeEnemyScore()
    {
        UpdateEnemyScore();
        percentE = ( (float)enemyScore/ max);
        gameManager.instance.EnemyBar.GetComponent<Image>().fillAmount = 1-percentE;
    }
    void UpdateEnemyScore()
    {
        gameManager.instance.enemyScoreTxt.text = enemyScore.ToString() + '/' + max.ToString();
    }
}
