using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaculePrefabs;

    //private Vector3 spawnpos = new Vector3(30, 0, 0);
    private Vector3 spawnPos;
    private float startDelay = 2;
    private float repeatRate = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnPos = this.transform.position;
        InvokeRepeating("SpawnObstacule",startDelay,repeatRate);
    }

    void SpawnObstacule()
    {
        GameObject obstaculePrefab = obstaculePrefabs[Random.Range(0, obstaculePrefabs.Length)];
        Instantiate(obstaculePrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
