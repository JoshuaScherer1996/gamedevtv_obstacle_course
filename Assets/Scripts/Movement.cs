using UnityEngine;

public class Movement : MonoBehaviour
{
    // Creating constants
    [SerializeField] float xForce = 0f;
    [SerializeField] float yForce = 0.01f;
    [SerializeField] float zForce = 0f;

    void Update()
    {
        // Moveing the object in the specified directions.
        transform.Translate(xForce, yForce, zForce);
    }
}
