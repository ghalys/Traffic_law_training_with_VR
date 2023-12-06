using UnityEngine;

public class DetectCollision : MonoBehaviour
 
{
    public string tago;
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision détectée avec : " + collision.gameObject.name);
        // Ajoutez ici le code que vous souhaitez exécuter lorsque la collision est détectée.
        if(collision.gameObject.tag==tago){
            Debug.Log("ok");
        }
    }
}
