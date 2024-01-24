using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRocketController : MonoBehaviour
{
    [SerializeField] float radius = 2f;
    [SerializeField] Transform player;
    [SerializeField] MaterialCollection materialCollection;

    //public var
    public GameObject playerMaterialBag;
    public AudioSource audioSRC;
    public AudioClip pickUpSFX;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        materialCollection = GameObject.FindGameObjectWithTag("MaterialCollection").GetComponent<MaterialCollection>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerChecker();
        showMaterialBag();

        audioSFX();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    private void PlayerChecker()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        if (distance <= radius)
        {
            if (materialCollection.PlayerMaterialAcquired == true)
            {

                materialCollection.PlayerMaterialAcquired = false;
                materialCollection.PlayerMaterialCounter++;
            }
        }
    }

    public void showMaterialBag()
    {
        if(materialCollection.PlayerMaterialAcquired)
        {
            playerMaterialBag.SetActive(true);
        }
        else
        {
            playerMaterialBag.SetActive(false);
        }
    }
    public void audioSFX()
    {
        if(materialCollection.PlayerMaterialAcquired == false)
        {
            audioSRC.clip = pickUpSFX;
            audioSRC.Play();
        }
    }
}
