using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 0;
    private float repeatRate = 1;
    private PlayerController playerControllerScript;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        Invoke("randomSpawnObstacle", startDelay);

    }
    void randomSpawnObstacle()
    {
        repeatRate = Random.Range(0.5f, 2);
        Invoke("spawnObstacle", repeatRate);

    }
    void spawnObstacle()
    {
        if (!playerControllerScript.gameOver)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
            Invoke("randomSpawnObstacle", startDelay);
        }

    }

}
