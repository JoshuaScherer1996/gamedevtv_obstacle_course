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
        gameObject.SetActive(false);
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

    // Used to get the accurate player location from within the TriggerProjectile script.
    public void SetTargetPosition(Vector3 position)
    {
        playerPosition = position;
    }
}
