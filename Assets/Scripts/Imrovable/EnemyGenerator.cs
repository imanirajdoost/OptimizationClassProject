using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    //TODO: Improve this code as much as possible
    //Watch the videos about "Object Pooling", "Optimizing your Code" and "Using Events and delegates"
    //Tip: The enemy objects disable automatically when you shoot them

    public GameObject enemyPrefab;      //Enemy prefab to spawn
    public int maxNumberOfEnemies = 2;  //Maximum number of enemies allowed in the scene

    private int currentNumberOfEnemies = 0;

    private void Start()
    {
        InvokeRepeating("GenerateEnemy",0,5f);      //Generate enemies each 5 seconds, starting from the begining of the game
    }

    private void GenerateEnemy()
    {
        //If we still have room for enemies, then create enemies
        if(currentNumberOfEnemies < maxNumberOfEnemies)
        {
            //Instantiate an enemy prefab in the game object's current position
            Instantiate(enemyPrefab,transform.position,Quaternion.identity);
        }
    }

    private void Update()
    {
        //In each frame we check the number of enemies in the scene
        //and we update the current number of enemies variable
        EnemyManager[] enemyArray = FindObjectsOfType<EnemyManager>();
        currentNumberOfEnemies = enemyArray.Length;
    }
}
