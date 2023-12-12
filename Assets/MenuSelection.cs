using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI; 

public class MenuSelection : MonoBehaviour
{
    private XRRayInteractor rayInteractor;

    private void Start()
    {
        // Assurez-vous d'attacher ce script au même GameObject que XRRayInteractor
        // rayInteractor = GetComponent<XRRayInteractor>();

        // // Vérifiez si XRRayInteractor est attaché
        // if (rayInteractor != null)
        // {
        //     // Abonnez-vous à l'événement de sélection
        //     rayInteractor.selectEntered.AddListener(OnSelectEntered);
        // }
        // else
        // {
        //     Debug.LogError("XRRayInteractor non trouvé sur le GameObject.");
        // }
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        // // Gérez la sélection ici, par exemple, activez un bouton dans le menu Canvas
        // if (args.interactable is Button)
        // {
        //     Button button = args.interactable.GetComponent<Button>();
        //     if (button != null)
        //     {
        //         // Effectuez l'action souhaitée lorsque le bouton est sélectionné
        //         button.onClick.Invoke();
        //     }
        // }
    }
}
