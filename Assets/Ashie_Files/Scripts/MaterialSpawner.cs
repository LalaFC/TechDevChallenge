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
            if (canSpawn == true && limit == false)
                StartCoroutine(Spawn(0));
        }
        else 
        {
            ItemCounter(6);
            if (canSpawn == true && limit == false)
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
    }

}
