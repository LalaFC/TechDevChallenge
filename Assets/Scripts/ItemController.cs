using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    [SerializeField] float radius = 2.5f;
    [SerializeField] Transform player;
    [SerializeField] FirstPersonController playerScript;
    [SerializeField] Transform enemy;
    [SerializeField] EnemyController enemyScript;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        PlayerChecker();
        EnemyChecker();
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
            playerScript.ItemAcquired = true;
            Destroy(this.gameObject);
        }
    }

    private void EnemyChecker()
    {
        float distance = Vector3.Distance(transform.position, enemy.position);
        if (distance <= radius)
        {
            enemyScript.ItemAcquired = true;
            enemyScript.ItemExists = false;
            Destroy(this.gameObject);
        }
    }
}
