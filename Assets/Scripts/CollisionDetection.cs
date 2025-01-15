using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        // Executes the logic if the other gameobject has the tag Player.
        if (other.gameObject.tag == "Player")
        {
            // Changes the color propertie of the other gameobject.
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hitable";
        }
    }
}
