using UnityEngine;

/// <summary>
/// Component placed on a Pipe. 
/// Responsible for positioning the pipe and moving it to the left
/// </summary>
public class PipeMovement : MonoBehaviour
{
    /// <summary>
    /// The spawn location of the pipe on the Ox axis
    /// </summary>
    public float spawnX = 13.0f;

    /// <summary>
    /// The lowest height the pipe can spawn at
    /// </summary>
    public float lowerLimit = -4.9f;

    /// <summary>
    /// The highest height the pipe can spawn at
    /// </summary>
    public float upperLimit = -0.32f;

    /// <summary>
    /// The speed of the pipe, towards the left side
    /// </summary>
    public float speed = 1;

    void Start()
    {
        // Choose a random height between lower and upper limit
        float y = Random.Range(lowerLimit, upperLimit);
        // Set the initial position
        transform.position = new Vector3(spawnX, y);
    }

    void Update()
    {
        // Move the pipe towards the left
        transform.position += new Vector3(-Time.deltaTime * speed, 0);
    }
}
