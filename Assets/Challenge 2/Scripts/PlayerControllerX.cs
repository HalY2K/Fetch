using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //public GameObject dogPrefab;
    public GameObject[] animalPrefabs;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPos = new Vector3(Random.Range(15, 15), 0, 0);
            Instantiate(animalPrefabs[3], spawnPos, animalPrefabs[3].transform.rotation);
        }
    }
}
