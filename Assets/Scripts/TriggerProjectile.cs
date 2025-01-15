using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    // Creating the variables.
    [SerializeField] GameObject[] projectiles;

    private void OnTriggerEnter(Collider other)
    {
        // Executes the logic if the other project has the tag Player.
        if (other.gameObject.tag == "Player")
        {
            // Simple loop that goes through all the projectiles in the array and is null safe.
            foreach (GameObject projectile in projectiles)
            {
                if (projectile != null) 
                {
                    // Activates the projectile instances.
                    projectile.SetActive(true);
                }
            }
        }
    }
}
