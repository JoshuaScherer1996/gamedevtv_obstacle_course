using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    // Creating the variables.
    [SerializeField] GameObject[] projectiles;

    private void OnTriggerEnter(Collider other)
    {

        Vector3 playerSnapshotPosition = other.transform.position;

        // Executes the logic if the other project has the tag Player.
        if (other.gameObject.tag == "Player")
        {
            // Simple loop that goes through all the projectiles in the array and is null safe.
            foreach (GameObject projectile in projectiles)
            {
                if (projectile != null)
                {
                    // Uses the method from the FlyAtPlayer script to pass the current player position value to it.
                    FlyAtPlayer flyAtPlayer = projectile.GetComponent<FlyAtPlayer>();
                    if (flyAtPlayer != null)
                    {
                        flyAtPlayer.SetTargetPosition(playerSnapshotPosition);
                    }


                    // Activates the projectile instances.
                    projectile.SetActive(true);
                }
            }
        }
    }
}
