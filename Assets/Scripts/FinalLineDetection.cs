using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLineDetection : MonoBehaviour

{
    // Définissez le message que vous souhaitez afficher
    public string message = "Félicitations, vous avez atteint la ligne de fin !";

    private void OnTriggerEnter(Collider other)
    {
        // Vérifiez si l'objet qui entre en collision est le joueur (vous pouvez ajuster cela selon votre scénario)
        if (other.CompareTag("Vehicle"))
        {
            // Affichez le message dans la console (vous pouvez remplacer cela par un affichage dans l'interface utilisateur)
            Debug.Log(message);

            // Vous pouvez également afficher le message dans l'interface utilisateur ou déclencher d'autres actions ici
            // Exemple : UIManager.Instance.DisplayMessage(message);
        }
    }
}
