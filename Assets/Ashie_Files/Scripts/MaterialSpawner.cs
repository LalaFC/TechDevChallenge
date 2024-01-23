using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MaterialSpawner : MonoBehaviour
{
    public GameObject Material;
    [SerializeField] Vector3 RandomVector;
    [SerializeField] bool canSpawn = true, limit = false;
    [SerializeField] float TimeCount;
    [SerializeField] int SpawnedMatCount;
    [Range(2, 7)] public float spawnCD;
    private bool spotAvailable = false;

    private void Awake()
    {
    }
    // Update is called once per frame
    void Update()
    {
        Randomize();
        TimeCount = Time.time;

        if (TimeCount < 5)
        { 
            ItemCounter(3);
            if (canSpawn == true && limit == false && spotAvailable)
                StartCoroutine(Spawn(0));
        }
        else
        {
            ItemCounter(6);
            if (canSpawn == true && limit == false && spotAvailable)
                StartCoroutine(Spawn(spawnCD));
        }
        SpawnedMatCount = GameObject.FindGameObjectsWithTag("Material").Length;

    }
    IEnumerator Spawn(float CD)
    {
        canSpawn = false;
        Instantiate(Material, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(CD);
        canSpawn = true;
    }
    void ItemCounter(int maxNum)
    {
        if (GameObject.FindGameObjectsWithTag("Material").Length >= maxNum)
        {
            limit = true;
        }
        else 
        limit = false;
    }

    void Randomize()
    {
        RandomVector = UnityEngine.Random.onUnitSphere * 10;
        transform.position = RandomVector;
        LookRotation();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player" || collision.collider.tag == "Enemy" || collision.collider.tag == "Material" || collision.collider.tag == "Spaceship")
            spotAvailable = false;
    }
    private void OnCollisionExit(Collision collision)
    {
        spotAvailable = true;
    }
    void LookRotation()
    {
        float rotspeed = 20;
        Vector3 relativePos = GameObject.FindGameObjectWithTag("Planet").transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, rotspeed * Time.deltaTime);
    }

}
