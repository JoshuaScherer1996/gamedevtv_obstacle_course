using UnityEngine;

public class Drop : MonoBehaviour
{
    // Cretaing the variables.
    [SerializeField] private float timeToDrop = 3.0f;
    private MeshRenderer meshRenderer;
    private Rigidbody rigidBody;

    private void Start()
    {
        // Cashing the objects components.
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        // Deactivating the components at the start of the game.
        meshRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    private void Update()
    {
        // Trigger logic if the passed time is greater than timeToDrop.
        if (Time.time > timeToDrop)
        {
            // Activates the components.
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
