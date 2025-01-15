using UnityEngine;

public class Spin : MonoBehaviour
{
    // Creating the variables.
    [SerializeField] private float xRotationSpeed;
    [SerializeField] private float yRotationSpeed = 60f;
    [SerializeField] private float zRotationSpeed;

    private void Update()
    {
        SpinObject();
    }

    // Decides how the object rotates.
    private void SpinObject()
    {
        // Rotating the object.
        transform.Rotate(
            xRotationSpeed * Time.deltaTime, 
            yRotationSpeed * Time.deltaTime, 
            zRotationSpeed * Time.deltaTime
            );
    }
}
