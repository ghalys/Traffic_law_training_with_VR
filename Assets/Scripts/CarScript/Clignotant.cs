using UnityEngine;

public class Clignotant : MonoBehaviour
{
    public float dureeClignotement = 1f; // Durée d'un cycle de clignotement en secondes
    private bool clignotantlumineux = false;
    public bool clignotantActif = false;
    private float tempsProchainClignotement;
    private Renderer rend;
    public FailMenu fail_menu;

    void Start()
    {
        tempsProchainClignotement = Time.time + dureeClignotement;

        rend = GetComponent<Renderer>();
        rend.enabled = clignotantActif;
    }

    void Update()
    {
        if(clignotantActif){

        // Vérifier si le temps du prochain clignotement est atteint
        if (Time.time >= tempsProchainClignotement)
        {
            // Inverser l'état du clignotant
            clignotantlumineux = !clignotantlumineux;

            // Activer ou désactiver le composant Renderer
            rend.enabled = clignotantlumineux;

            // Mettre à jour le temps du prochain clignotement
            tempsProchainClignotement = Time.time + dureeClignotement;
        }
        }
        else{
            rend.enabled = clignotantActif;

        }
    }
 
public void CheckLeftSignal()
    {
        if (!clignotantActif)
        {
            fail_menu.gameObject.SetActive(true);
            fail_menu.SetMessageNoLeftSignal();
        }
    }
}