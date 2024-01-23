using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialCollection : MonoBehaviour
{
    [SerializeField] bool playerMaterialAcquired = false;
    public bool PlayerMaterialAcquired { get { return playerMaterialAcquired; } set { playerMaterialAcquired = value; } }
    [SerializeField] int playerMaterialCounter = 0;
    public int PlayerMaterialCounter { get {  return playerMaterialCounter; } set {  playerMaterialCounter = value; } }
    [SerializeField] bool enemyMaterialAcquired = false;
    public bool EnemyMaterialAcquired { get { return enemyMaterialAcquired; } set {  enemyMaterialAcquired = value; } }
    [SerializeField] int enemyMaterialCounter = 0;
    public int EnemyMaterialCounter { get { return enemyMaterialCounter; } set {  enemyMaterialCounter = value; } }
}