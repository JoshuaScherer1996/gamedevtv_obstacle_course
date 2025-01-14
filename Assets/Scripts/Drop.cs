using UnityEngine;

public class Drop : MonoBehaviour
{
    const float timeToDrop = 3.0f;

    private void Update()
    {
        if (Time.time > timeToDrop)
        {
            Debug.Log($"The time is: {Time.time}!");
        }
    }
}
