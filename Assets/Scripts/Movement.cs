using UnityEngine;

public class Movement : MonoBehaviour
{
    // Cretaing the variables.
    [SerializeField] private float moveSpeed = 10f;

    private void Start()
    {
        PrintInstruction();
    }

    private void Update()
    {
        MovePlayer();
    }

    // Printing some basic instructions to the console.
    private void PrintInstruction()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("If you can see this that means that you are a developer. Great!");
        Debug.Log("Use WASD to move. Don't bump into the obstacles!");
    }

    private void MovePlayer()
    {
        // Creating variables
        float xForce = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yForce = 0f;
        float zForce = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        // Moveing the object in the specified directions.
        transform.Translate(xForce, yForce, zForce);
    }
}
