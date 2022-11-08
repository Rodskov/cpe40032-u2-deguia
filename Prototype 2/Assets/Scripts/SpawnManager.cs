using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] humanPrefabs;
    private float spawnRangeX = 19;
    private float spawnLocationZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, humanPrefabs.Length);
        Vector3 spawnLocation = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnLocationZ);

        Instantiate(humanPrefabs[animalIndex], spawnLocation, humanPrefabs[animalIndex].transform.rotation);
    }
}
