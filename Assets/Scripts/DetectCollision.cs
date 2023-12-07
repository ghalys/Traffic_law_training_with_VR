using UnityEngine;

public class DetectCollision : MonoBehaviour
 
{
    public string tago;
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision détectée avec : " + collision.gameObject.name);
        if(collision.gameObject.tag=="VehicleRobot"){
            Debug.Log("Game over");
        }
    }
}
