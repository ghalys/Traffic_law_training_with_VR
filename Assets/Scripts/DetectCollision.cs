using TMPro;
using UnityEngine;

public class DetectCollision : MonoBehaviour
 
{
    public string tago;
    public GameObject canvas;
    void OnCollisionEnter(Collision collision)
    {
        canvas.SetActive(true);
        TextMeshProUGUI texteDuCanvas = canvas.GetComponentInChildren<TextMeshProUGUI>();

            if (texteDuCanvas != null)
            {
                texteDuCanvas.text = "Collision détectée avec : " + collision.gameObject.name;
            }
        Debug.Log("Collision détectée avec : " + collision.gameObject.name);
        
        if(collision.gameObject.tag=="VehicleRobot"){
            Debug.Log("Game over");
            
        }
    }
}
