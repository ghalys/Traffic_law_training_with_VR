using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLineDetection : MonoBehaviour

{
    public DetectFailure vehicule;
    public GameObject bravo;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Vehicle"))
        {
            
                bravo.SetActive(true);
                
        }
    }
}
