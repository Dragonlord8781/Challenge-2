using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs; //prefabs

    private float spawnLimitXLeft = -22; // left limit
    private float spawnLimitXRight = 7; // right limit 
    private float spawnPosY = 30; // position

    private float startDelay = 1.0f; // start delay
    private float spawnInterval; // spawn delay

    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = Random.Range(3, 5);  //random time for spawn delay
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval); // invokes spawning the ball
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
