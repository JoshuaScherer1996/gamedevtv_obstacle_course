using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;

    void Update()
    {
        // Creating variables
        float xForce = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yForce = 0f;
        float zForce = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        // Moveing the object in the specified directions.
        transform.Translate(xForce, yForce, zForce);
    }
}
