using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MaterialDespawner : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform enemy;
    [SerializeField] MaterialCollection materialCollection;
    [SerializeField] float radius = 1f;
    private MeshRenderer Mesh;
    private bool startTimer=false;
    [SerializeField] float Timer;

    // Start is called before the first frame update
    void Awake()
    {
        Mesh = GetComponentInChildren<MeshRenderer>();
        Mesh.enabled= false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Planet")
        {
            Mesh.enabled = true;
            startTimer = true;
        }

    }
    private void FixedUpdate()
    {
        if (startTimer) 
        {
            Timer += Time.deltaTime;
        }
        if (Timer >= 5)
            Destroy(this.gameObject);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
        materialCollection = GameObject.FindGameObjectWithTag("MaterialManager").GetComponent<MaterialCollection>();

    }

    // Update is called once per frame
    void Update()
    {
        PlayerChecker();
        EnemyChecker();
    }

    private void PlayerChecker()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        if (distance <= radius && materialCollection.PlayerMaterialAcquired == false)
        {
            materialCollection.PlayerMaterialAcquired = true;
            Destroy(this.gameObject);
        }
    }

    private void EnemyChecker()
    {
        float distance = Vector3.Distance(transform.position, enemy.position);
        if (distance <= radius)
        {
            materialCollection.EnemyMaterialAcquired = true;
            Destroy(this.gameObject);
        }
    }
}
