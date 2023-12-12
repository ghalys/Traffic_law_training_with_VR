using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalLineDetection : MonoBehaviour

{
    // Définissez le message que vous souhaitez afficher
    public GameObject canvas;
    private void OnTriggerEnter(Collider other)
    {
        // Vérifiez si l'objet qui entre en collision est le joueur (vous pouvez ajuster cela selon votre scénario)

        if (other.CompareTag("Vehicle"))
        {
            canvas.SetActive(true);
            TextMeshProUGUI texteDuCanvas = canvas.GetComponentInChildren<TextMeshProUGUI>();

            if (texteDuCanvas != null)
            {
                texteDuCanvas.text = "Félicitations, vous avez atteint la ligne de fin !";
            }
        }
    }
}
