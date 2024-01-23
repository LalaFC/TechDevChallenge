using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpaceShipeController : MonoBehaviour
{
    [SerializeField] float radius = 2.5f;
    [SerializeField] Transform player;
    [SerializeField] FirstPersonController playerScript;
    [SerializeField] int itemCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
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
            if (playerScript.ItemAcquired)
            {
                playerScript.ItemAcquired = false;
                itemCounter++;
            }
        }
    }
}
