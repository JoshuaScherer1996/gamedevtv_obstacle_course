using UnityEngine;

public class Spin : MonoBehaviour
{
    // Creating the variables.
    [SerializeField] private float xRotationSpeed = 0f;
    [SerializeField] private float yRotationSpeed = 60f;
    [SerializeField] private float zRotationSpeed = 0f;

    void Update()
    {
        SpinObject();
    }

    // Decides how the object rotates.
    void SpinObject()
    {
        // Creating variables.
        float xAngle = xRotationSpeed * Time.deltaTime;
        float yAngle = yRotationSpeed * Time.deltaTime;
        float zAngle = zRotationSpeed * Time.deltaTime;

        // Rotating the object.
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
