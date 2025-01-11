using UnityEngine;

public class Movement : MonoBehaviour
{
    // Creating constants
    const float xForce = 0f;
    const float yForce = 0.01f;
    const float zForce = 0f;

    void Update()
    {
        // Moveing the object in the specified directions.
        transform.Translate(xForce, yForce, zForce);
    }
}
