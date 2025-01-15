using UnityEditor.Rendering;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    // Creating the variables.
    [SerializeField] private Transform player;
    [SerializeField] private float projectileSpeed = 10.0f;
    Vector3 playerPosition;

    private void Awake()
    {
        // Deactivates the object.
        Debug.Log($"{name}: Awake called");
        gameObject.SetActive(false);
        Debug.Log($"{name}: player position is {playerPosition}");
    }

    private void Start()
    {
        // Gets the position opf the player Transfrom object.
        Debug.Log($"The variable transform player is: {player.position}");
        
        Debug.Log($"The variable playerPosition is: {playerPosition}");
        playerPosition = player.position;
        Debug.Log($"The variable playerPosition is: {playerPosition}");
    }

    private void Update()
    {
        MoveTowards();
        DestroyWhenReached();
    }

    // Executes the projectile path and speed logic.
    private void MoveTowards()
    {
        // Calculates the path and speed of the projectile.
        transform.position = Vector3.MoveTowards(
            transform.position,
            playerPosition,
            projectileSpeed * Time.deltaTime
            );
    }

    // Executes the destruction logic.
    private void DestroyWhenReached()
    {
        // When tje object position is equal to the target position it is destroyed.
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
