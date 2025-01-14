using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag != "Hitable")
        {
            score++;
            Debug.Log($"You have bumped into objects {score} many times. Be more careful!");
        }

    }
}
