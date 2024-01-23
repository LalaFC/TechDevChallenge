using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static gameManager instance { get; private set; }

    [Header("Game Objects")]
    public GameObject planet;
    public GameObject player;
    public GameObject material;
    public GameObject spaceship;
    [Header("Scripts")]
    public FirstPersonController PlayerMvmt;
    public RandomSpawner MatSpawner;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
