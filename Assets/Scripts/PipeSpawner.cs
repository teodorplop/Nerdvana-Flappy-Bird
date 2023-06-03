using UnityEngine;

/// <summary>
/// Component responsible for spawning pipe prefabs
/// </summary>
public class PipeSpawner : MonoBehaviour
{
    /// <summary>
    /// Reference to the pipe prefab GameObject
    /// </summary>
    public GameObject pipePrefab;

    /// <summary>
    /// Delay between spawning of each pipe
    /// </summary>
    public float delay = 2;

    /// <summary>
    /// Current time passed
    /// </summary>
    float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delay)
        {
            // If the timer surpassed our defined delay, we spawn a pipe
            Instantiate(pipePrefab);
            // We reset the timer
            timer -= delay;
        }
    }
}
