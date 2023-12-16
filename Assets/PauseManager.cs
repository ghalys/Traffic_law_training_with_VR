using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//using UnityEngine.Rendering.PostProcessing;

public class PauseManager : MonoBehaviour
{
    public InputAction pauseAction;
    public GameObject pausePanel;
    public GameObject ParameterPanel;
    public GameObject SurePanel;

    public Transform player;

    public float spawnDistance = 2 ;

    public float hauteur = 2 ;

    public bool ispaused=true ;
    public List<GameObject> listeDeGameObjects;

    

    public GameObject Carcomponents ;

    public GameObject RightHandJeu ;
    public GameObject RightHandPause ;
    public GameObject LeftHandJeu ;
    public GameObject LeftHandPause ; 
    public GameObject GameObjectJeu   ;



    //public PostProcessVolume postProcessVolume; // Assurez-vous que ce composant est attaché à votre caméra

    private void OnEnable()
    {
        pauseAction.Enable();
    }

    private void OnDisable()
    {
        pauseAction.Disable();
    }

    void Start()
    {

        pauseAction.started += OnPause;
        
    }

    void OnPause(InputAction.CallbackContext context)
    {
        if (ispaused)
        {
            // Activer/désactiver le panneau Pause
            pausePanel.SetActive(false);
            ParameterPanel.SetActive(false);
            SurePanel.SetActive(false);
            
            ispaused = false;
            Time.timeScale = 1;
            Carcomponents.SetActive(true) ;
            RightHandPause.SetActive(false) ;
            LeftHandPause.SetActive(false) ;
            RightHandJeu.SetActive(true) ;
            LeftHandJeu.SetActive(true) ;
            GameObjectJeu.SetActive(true) ;

            
        }
        else 
        {
            // Activer/désactiver le panneau Pause
            pausePanel.SetActive(true);
            ispaused = true;
            Time.timeScale = 0;
            pausePanel.transform.position=player.position + new Vector3(player.forward.x,hauteur,player.forward.z).normalized*spawnDistance ;
            pausePanel.transform.LookAt(new Vector3(2 * pausePanel.transform.position.x - player.position.x, pausePanel.transform.position.y, 2 * pausePanel.transform.position.z - player.position.z));
            ParameterPanel.transform.position=player.position + new Vector3(player.forward.x,hauteur,player.forward.z).normalized*spawnDistance ;
            ParameterPanel.transform.LookAt(new Vector3(2 * ParameterPanel.transform.position.x - player.position.x, ParameterPanel.transform.position.y, 2 * ParameterPanel.transform.position.z - player.position.z));     
            SurePanel.transform.position=player.position + new Vector3(player.forward.x,hauteur,player.forward.z).normalized*spawnDistance ;
            SurePanel.transform.LookAt(new Vector3(2 * SurePanel.transform.position.x - player.position.x, SurePanel.transform.position.y, 2 * SurePanel.transform.position.z - player.position.z));                   
            Carcomponents.SetActive(false) ;
            RightHandPause.SetActive(true) ;
            LeftHandPause.SetActive(true) ;
            RightHandJeu.SetActive(false) ;
            LeftHandJeu.SetActive(false) ;
            GameObjectJeu.SetActive(false) ;
        }

        // Activer/désactiver l'effet de flou
       // if (postProcessVolume != null)
       // {
           // postProcessVolume.enabled = !postProcessVolume.enabled;
       // }

        // Mettez ici d'autres actions que vous souhaitez effectuer lors de la pause
    }
}
