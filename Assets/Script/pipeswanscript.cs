using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float moveSpeed = 5f; // Ensure this matches the PipeMoveScript
    public float pipeSpacing = 10f; // Desired horizontal distance between pipes
    public float heightOffset = 10f;
    private float spawnRate = 2;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = pipeSpacing / moveSpeed;
        // spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spawnRate)
        {
        timer += Time.deltaTime;
        }
        else{
            spawnPipe();
            timer = 0f;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
