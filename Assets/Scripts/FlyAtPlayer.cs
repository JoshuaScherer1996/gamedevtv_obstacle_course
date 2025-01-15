using UnityEditor.Rendering;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    // Creating the variables.
    [SerializeField] private Transform player;
    [SerializeField] private float projectileSpeed = 10.0f;
    Vector3 playerPosition;

    void Start()
    {
        // Gets the position opf the player Transfrom object.
        playerPosition = player.position;
    }

    void Update()
    {
        MoveTowards();
    }

    void MoveTowards()
    {
        // Calculates the path and speed of the projectile.
        transform.position = Vector3.MoveTowards(
            transform.position,
            playerPosition,
            projectileSpeed * Time.deltaTime
            );
    }
}
