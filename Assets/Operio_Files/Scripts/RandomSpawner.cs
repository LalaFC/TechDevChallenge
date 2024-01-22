using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject Material;
    [SerializeField] Vector3 RandomVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Spawn();

        Randomize();
    }
    void Spawn()
    {
        if (Input.GetKey(KeyCode.A))
            Instantiate(Material, RandomVector, Quaternion.identity);
    }
    void Randomize()
    {
        if (Input.GetKey(KeyCode.B))
            RandomVector = Random.onUnitSphere * 10;
    }
}
