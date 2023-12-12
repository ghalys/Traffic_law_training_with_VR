using UnityEngine;

public class Clignotant : MonoBehaviour
{
    public float dureeClignotement = 1f; // Durée d'un cycle de clignotement en secondes
    public bool clignotantActive = false;
    private bool clignotantActif = false;
    private float tempsProchainClignotement;
    private Renderer rend;

    void Start()
    {
        tempsProchainClignotement = Time.time + dureeClignotement;

        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if(clignotantActive){

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
}