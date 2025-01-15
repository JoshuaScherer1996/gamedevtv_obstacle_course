using UnityEngine;

public class Score : MonoBehaviour
{
    // Cretaing the variables.
    private int score = 0;

    private void OnCollisionEnter(Collision other)
    {
        // Executes the logic if the other object has not the tag Hitable.
        if (other.gameObject.tag != "Hitable")
        {
            // Increases and prints the score.
            score++;
            Debug.Log($"You have bumped into objects {score} many times. Be more careful!");
        }

    }
}
