using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObstacle", 2f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnObstacle()
    {
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        Vector3 spawnPos = new Vector3(35, 0, 0);
        Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);
    }
}
