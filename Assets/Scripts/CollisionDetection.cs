using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        Debug.Log("A collision happened!");
    }
}
