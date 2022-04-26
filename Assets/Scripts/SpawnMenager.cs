using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMenager : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float spawnDelay = 0f;
    private float spawnInterval = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SpawnObjects()
    {
        if (CanvansMenager.PlayGame)
        {
            float spawnCount = Random.Range(6, 10);
            // Set random spawn location and random object index
            Vector3 spawnLocation = new Vector3(spawnCount, Random.Range(-4, 4), 20);
            int index = Random.Range(0, objectPrefabs.Length);

            // If game is still active, spawn new object
            if (!PlayerController.gameOver)
            {
                Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);
            }

        }
    }
}
