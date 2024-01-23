using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float walkSpeed = 6f;
    [SerializeField] Transform enemyRocket;
    [SerializeField] EnemyRocketController enemyRocketController;
    [SerializeField] MaterialCollection materialCollection;
    [SerializeField] private bool materialExists = true;
    public bool MaterialExists { get { return materialExists; } set { materialExists = value; } }
    [SerializeField] private bool withinBase = false;
    public bool WithinBase { get { return withinBase; } set { withinBase = value; } }

    private void Start()
    {
        enemyRocket = GameObject.FindGameObjectWithTag("EnemyRocket").transform;
        enemyRocketController = GameObject.FindGameObjectWithTag("EnemyRocket").GetComponent<EnemyRocketController>();
        materialCollection = GameObject.FindGameObjectWithTag("MaterialCollection").GetComponent<MaterialCollection>();
    }

    private void Update()
    {
        MoveToMaterial();
    }

    public void MoveToMaterial()
    {
        MaterialExists = (GameObject.FindWithTag("Material") == null) ? false : true;
        var step = walkSpeed * Time.deltaTime;
        float distance = Vector3.Distance(transform.position, enemyRocket.position);

        withinBase = (distance <= enemyRocketController.Radius) ? true : false;

        if (!materialCollection.EnemyMaterialAcquired && materialExists)
        {
            transform.position = Vector3.MoveTowards(transform.position, ClosestMaterial().position, step);
        }
        else if (!withinBase && (materialCollection.EnemyMaterialAcquired || !materialExists))
        {
            transform.position = Vector3.MoveTowards(transform.position, enemyRocket.position, step);
        }
    }

    private Transform ClosestMaterial()
    {
        GameObject closestObject = null;
        float closestDistance = Mathf.Infinity;

        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Material"))
        {
            float distance = Vector3.Distance(transform.position, obj.transform.position);
            if (distance < closestDistance)
            {
                closestObject = obj;
                closestDistance = distance;
            }
        }

        if (closestObject != null)
        {
            return closestObject.transform;
        }

        return closestObject.transform;
    }
}
