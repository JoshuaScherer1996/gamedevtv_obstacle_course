using UnityEngine;

public class Spin : MonoBehaviour
{
    // Creating the variables.
    [SerializeField] private float xRotationSpeed;
    [SerializeField] private float yRotationSpeed = 60f;
    [SerializeField] private float zRotationSpeed;

    void Update()
    {
        SpinObject();
    }

    // Decides how the object rotates.
    void SpinObject()
    {
        // Rotating the object.
        transform.Rotate(
            xRotationSpeed * Time.deltaTime, 
            yRotationSpeed * Time.deltaTime, 
            zRotationSpeed * Time.deltaTime
            );
    }
}
