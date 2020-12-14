using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float maxYpos;
    public float spawnTime;



    private void Update()
    {
        
    }
    private void SpawnPipe()
    {
        Instantiate(pipe, new Vector3 (
                                transform.position.x,
                                Random.Range(-maxYpos, maxYpos),
                                0),
                                Quaternion.identity
                                );
    }
    public void StartSpawningPipes()
    {
        InvokeRepeating(nameof(SpawnPipe), 0.1f, spawnTime);
    }

    public void StopSpawningPipes()
    {
        CancelInvoke(nameof(SpawnPipe));
    }
}
