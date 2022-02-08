using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabList;
    private int maximoPrefabs;
    private Vector3 spawnPos = new Vector3(25, 3, 0);
    private float startDelay = 0;
    private float repeatRate = 1;
    private PlayerController playerControllerScript;
    void Start()
    {
        maximoPrefabs = obstaclePrefabList.Length;
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
            int aleatorio = Random.Range(0, maximoPrefabs);
            Instantiate(obstaclePrefabList[aleatorio], spawnPos, obstaclePrefabList[aleatorio].transform.rotation);
            Invoke("randomSpawnObstacle", startDelay);
        }

    }

}
