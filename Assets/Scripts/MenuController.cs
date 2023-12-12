using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MenuController : MonoBehaviour
{
    public GameObject pauseMenu; // Faites glisser votre menu pause ici dans l'inspecteur

    private XRRayInteractor rayInteractor;

    void Start()
    {
        // Assurez-vous que le composant XRRayInteractor est attaché à votre objet
        rayInteractor = GetComponent<XRRayInteractor>();

        // Abonnez-vous à l'événement de clic sur le bouton de menu
        rayInteractor.selectEntered.AddListener(OnMenuButtonEnter);
    }

    void OnMenuButtonEnter(SelectEnterEventArgs args)
    {
        // Affichez ou masquez le menu pause lorsque le bouton de menu est enfoncé
        TogglePauseMenu();
    }

    void TogglePauseMenu()
    {
        // Inversez l'état actuel du menu pause
        bool isPaused = !pauseMenu.activeSelf;
        pauseMenu.SetActive(isPaused);

        // Mettez le temps du jeu à l'arrêt ou en mouvement en fonction de l'état du menu pause
        Time.timeScale = isPaused ? 0f : 1f;
    }
}
