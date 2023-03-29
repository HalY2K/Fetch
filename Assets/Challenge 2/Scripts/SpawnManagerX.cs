using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -9;
    private float spawnLimitXRight = 9;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    private bool canPressSpace = true;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        
    }
    IEnumerator DelaySpaceInput()
    {
        // Disable space key input
        canPressSpace = false;

        // Wait for one second
        yield return new WaitForSeconds(1f);

        // Enable space key input
        canPressSpace = true;
    }
    private void Update()
    {
        if (canPressSpace && Input.GetKeyDown(KeyCode.Space))
        {
            // Spawn the ball prefab
            Vector3 spawnPos = new Vector3(15, 0, 0);
            Instantiate(ballPrefabs[3], spawnPos, ballPrefabs[3].transform.rotation);

            // Start the delay coroutine
            StartCoroutine(DelaySpaceInput());
        }
    }
    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int ballIndex = Random.Range(0, ballPrefabs.Length-1);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
