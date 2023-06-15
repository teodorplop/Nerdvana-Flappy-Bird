using UnityEngine;

/// <summary>
/// Responsible for handling bird collision
/// </summary>
public class BirdCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Death")
        {
            // We end the session if we collided with a Death tag
            HandleDeath();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Score")
        {
            // We increment the score if we collided with a Score tag
            HandleScore();
        }
    }

    private void HandleDeath()
    {
        // Get all components that have to be disabled at the end of the session

        GetComponent<Bird>().enabled = false;

        FindObjectOfType<PipeSpawner>().enabled = false;
        foreach (PipeMovement pipe in FindObjectsOfType<PipeMovement>())
            pipe.enabled = false;

        foreach (MovingBackground bkg in FindObjectsOfType<MovingBackground>())
            bkg.enabled = false;
    }

    private void HandleScore()
    {
        // Get component of type Score and call Increment function from it
        FindObjectOfType<Score>().Increment();
    }
}
