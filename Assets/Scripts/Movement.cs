using UnityEngine;

public class Movement : MonoBehaviour
{


    void Update()
    {
        // Creating variables
        float xForce = Input.GetAxis("Horizontal");
        float yForce = 0f;
        float zForce = Input.GetAxis("Vertical");

        // Moveing the object in the specified directions.
        transform.Translate(xForce, yForce, zForce);
    }
}
