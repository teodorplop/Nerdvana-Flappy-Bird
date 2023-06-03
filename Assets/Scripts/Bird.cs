using UnityEngine;

/// <summary>
/// Component responsible for handling input and gravity on the bird
/// </summary>
public class Bird : MonoBehaviour
{
    /// <summary>
    /// How strong is the gravity?
    /// </summary>
    public float gravity = 1;

    /// <summary>
    /// How strong is the jump?
    /// </summary>
    public float jumpForce = 5;

    /// <summary>
    /// Current speed of the bird
    /// </summary>
    float speed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // If we pressed space, we set the speed to a high value
            // So that the bird can 'take off'
            speed = jumpForce;
        }
        else
        {
            // Otherwise, we modify the speed by the gravity
            speed -= Time.deltaTime * gravity;
        }

        // The bird moves with the current speed
        transform.position += new Vector3(0, speed * Time.deltaTime);
    }
}
