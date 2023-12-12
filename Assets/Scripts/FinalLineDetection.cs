using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLineDetection : MonoBehaviour

{
    // Définissez le message que vous souhaitez afficher
    public VehicleControl vehicleControl;
    public GameObject bravo;
    private void OnTriggerEnter(Collider other)
    {
        // Vérifiez si l'objet qui entre en collision est le joueur (vous pouvez ajuster cela selon votre scénario)
        if (other.CompareTag("Vehicle"))
        {
            if (vehicleControl.PriorityCheck == true)
            {
                bravo.SetActive(true);
    
                }
        // Affichez le message dans la console (vous pouvez remplacer cela par un affichage dans l'interface utilisateur)


        // Vous pouvez également afficher le message dans l'interface utilisateur ou déclencher d'autres actions ici
        // Exemple : UIManager.Instance.DisplayMessage(message);
    }
    }
}
