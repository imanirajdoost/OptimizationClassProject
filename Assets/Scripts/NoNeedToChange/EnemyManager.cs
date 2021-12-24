using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages enemy behavior
/// </summary>
public class EnemyManager : MonoBehaviour
{
    private GameObject player;  //Player object
    public float speed = 100;   //Speed of movement

    /// <summary>
    /// If the player object is null,
    /// find it and cache it
    /// </summary>
    private void OnEnable()
    {
        if (player == null)
            FindPlayer();
    }

    /// <summary>
    /// Find the player object
    /// </summary>
    private void FindPlayer()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    /// <summary>
    /// Runs every frame
    /// </summary>
    private void Update()
    {
        //Move towards the player each frame
        if (player != null)
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
