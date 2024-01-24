using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static gameManager instance { get; private set; }

    [Header("Game Objects")]
    public GameObject Planet;
    public GameObject Player;
    public GameObject Spaceship;
    public GameObject Enemy;
    public GameObject EnemyBase;
    public GameObject Material;
    public GameObject Spawner;
    public GameObject MaterialManager;
    public GameObject Camera;

    [Header("Progress Bars")]
    public GameObject PlayerBar;
    public GameObject EnemyBar;
    public GameObject PlayerScore;
    public GameObject EnemyScore;

    [Header("Scripts")]
    public FirstPersonController PlayerMvmt;
    public RandomSpawner MatSpawner;
    public MaterialCollection ScoreCounter;


    [Header("TextBox")]
    public TextMeshProUGUI playerScoreTxt;
    public TextMeshProUGUI enemyScoreTxt;

    private void Awake()
    {
        if (instance != null && instance != this) { Destroy(this); }
        else { instance = this; }

        ScoreCounter = MaterialManager.GetComponent<MaterialCollection>();
        playerScoreTxt = PlayerScore.GetComponent<TextMeshProUGUI>();
        enemyScoreTxt = EnemyScore.GetComponent<TextMeshProUGUI>();
    }
}
