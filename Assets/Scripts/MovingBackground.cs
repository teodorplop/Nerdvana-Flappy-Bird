using UnityEngine;

/// <summary>
/// Component responsible for moving the object towards the left
/// </summary>
public class MovingBackground : MonoBehaviour
{
    /// <summary>
    /// How fast should the object move
    /// </summary>
    public float speed;

    /// <summary>
    /// When this horizontal limit is reached, the object is moved to the right
    /// </summary>
    public float leftLimit;

    /// <summary>
    /// Object horizontal dimension
    /// </summary>
    private float size;

    void Start()
    {
        // Fetch the size of the renderer
        size = GetComponent<SpriteRenderer>().size.x;
    }

    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;
        if (transform.position.x < leftLimit)
            transform.position += new Vector3(2 * size, 0, 0);
    }
}
