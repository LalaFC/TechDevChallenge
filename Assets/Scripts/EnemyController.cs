using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // public vars
    public float walkSpeed = 6;
    [SerializeField] Transform item;
    [SerializeField] Transform enemySpaceShip;
    [SerializeField] EnemySpaceShipController enemySpaceShipScript;
    [SerializeField] private bool itemAcquired = false;
    public bool ItemAcquired { get { return itemAcquired; } set { itemAcquired = value; } }
    [SerializeField] private bool itemExists = true;
    public bool ItemExists { get { return itemExists; } set { itemExists = value; } }
    [SerializeField] private bool withinBase = false;
    public bool WithinBase { get { return withinBase; } set { withinBase = value; } }

    private void Update()
    {
        MoveTowardsItem();
        //movement();
    }

    public void MoveTowardsItem()
    {
        var step = walkSpeed * Time.deltaTime;
        float distance = Vector3.Distance(transform.position, enemySpaceShip.position);

        withinBase = (distance <= enemySpaceShipScript.Radius) ? true : false;

        if (!itemAcquired && itemExists)
        {
            transform.position = Vector3.MoveTowards(transform.position, item.position, step);
        }
        else if (!withinBase && (itemAcquired || !itemExists))
        {
            transform.position = Vector3.MoveTowards(transform.position, enemySpaceShip.position, step);
        }
    }
}
