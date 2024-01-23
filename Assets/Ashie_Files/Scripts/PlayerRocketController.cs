using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRocketController : MonoBehaviour
{
    [SerializeField] float radius = 2f;
    [SerializeField] Transform player;
    [SerializeField] MaterialCollection materialCollection;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        materialCollection = GameObject.FindGameObjectWithTag("MaterialManager").GetComponent<MaterialCollection>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerChecker();
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
}
