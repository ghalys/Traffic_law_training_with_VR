using UnityEngine;

public class Clignotant : MonoBehaviour
{
    public float dureeClignotement = 1f; // Durée d'un cycle de clignotement en secondes
    private bool clignotantActif = false;
    private float tempsProchainClignotement;
    private Renderer rend;

    void Start()
    {
        // Initialiser le temps du prochain clignotement
        tempsProchainClignotement = Time.time + dureeClignotement;

        // Récupérer le composant Renderer
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        // Vérifier si le temps du prochain clignotement est atteint
        if (Time.time >= tempsProchainClignotement)
        {
            // Inverser l'état du clignotant
            clignotantActif = !clignotantActif;

            // Activer ou désactiver le composant Renderer
            rend.enabled = clignotantActif;

            // Mettre à jour le temps du prochain clignotement
            tempsProchainClignotement = Time.time + dureeClignotement;
        }
    }
}