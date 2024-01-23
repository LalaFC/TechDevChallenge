using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRocketController : MonoBehaviour
{
    [SerializeField] float radius = 2f;
    public float Radius {  get { return radius; } }
    [SerializeField] Transform enemy;
    [SerializeField] MaterialCollection materialCollection;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
        materialCollection = GameObject.FindGameObjectWithTag("MaterialCollection").GetComponent<MaterialCollection>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyChecker();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    private void EnemyChecker()
    {
        float distance = Vector3.Distance(transform.position, enemy.position);
        if (distance <= radius)
        {
            if (materialCollection.EnemyMaterialAcquired == true)
            {
                materialCollection.EnemyMaterialAcquired = false;
                materialCollection.EnemyMaterialCounter++;
            }
        }
    }
}
