using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision détectée avec : " + collision.gameObject.name);
        // Ajoutez ici le code que vous souhaitez exécuter lorsque la collision est détectée.
    }
}
