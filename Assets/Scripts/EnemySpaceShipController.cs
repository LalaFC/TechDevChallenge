using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpaceShipController : MonoBehaviour
{
    [SerializeField] float radius = 2.5f;
    public float Radius { get { return radius; } }
    [SerializeField] Transform enemy;
    [SerializeField] EnemyController enemyScript;
    [SerializeField] int itemCounter = 0;

    // Start is called before the first frame update
    void Start()
    {

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
            if (enemyScript.ItemAcquired)
            {
                enemyScript.ItemAcquired = false;
                itemCounter++;
            }
        }
    }
}
