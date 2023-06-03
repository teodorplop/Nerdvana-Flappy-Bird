using UnityEngine;

/// <summary>
/// Component responsible for moving the texture towards the left
/// </summary>
public class MovingBackground : MonoBehaviour
{
    /// <summary>
    /// How fast should the texture move
    /// </summary>
    public float speed;

    /// <summary>
    /// Reference to the sprite renderer component
    /// </summary>
    SpriteRenderer spriteRenderer;

    void Start()
    {
        // Fetch the SpriteRenderer component from this GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Get the current offset of the texture
        var offset = spriteRenderer.material.mainTextureOffset;
        
        // Move it
        offset.x += Time.deltaTime * speed;

        // Clamp [0, 1]
        offset.x %= 1.0f;

        // Set it back on the sprite renderer
        spriteRenderer.material.mainTextureOffset = offset;
    }
}
