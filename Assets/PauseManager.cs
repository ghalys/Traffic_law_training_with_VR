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
    public void ModeMenu(bool b){
         // Activer/désactiver le panneau Pause
            if (b){
              Time.timeScale = 0;
            }
            else{
                Time.timeScale = 1;
            }
            Carcomponents.SetActive(!b) ;
            RightHandPause.SetActive(b) ;
            LeftHandPause.SetActive(b) ;
            RightHandJeu.SetActive(!b) ;
            LeftHandJeu.SetActive(!b) ;
            GameObjectJeu.SetActive(!b) ;

    }

    void OnPause(InputAction.CallbackContext context)
    {
        if (ispaused)
        {
            pausePanel.SetActive(false);
            ParameterPanel.SetActive(false);
            SurePanel.SetActive(false);
            ModeMenu(false);
            ispaused = false;
            
        }
        else 
        {
            // Activer/désactiver le panneau Pause
            pausePanel.SetActive(true);
            ispaused = true;
            pausePanel.transform.position=player.position + new Vector3(player.forward.x,hauteur,player.forward.z).normalized*spawnDistance ;
            pausePanel.transform.LookAt(new Vector3(2 * pausePanel.transform.position.x - player.position.x, pausePanel.transform.position.y, 2 * pausePanel.transform.position.z - player.position.z));
            ParameterPanel.transform.position=player.position + new Vector3(player.forward.x,hauteur,player.forward.z).normalized*spawnDistance ;
            ParameterPanel.transform.LookAt(new Vector3(2 * ParameterPanel.transform.position.x - player.position.x, ParameterPanel.transform.position.y, 2 * ParameterPanel.transform.position.z - player.position.z));     
            SurePanel.transform.position=player.position + new Vector3(player.forward.x,hauteur,player.forward.z).normalized*spawnDistance ;
            SurePanel.transform.LookAt(new Vector3(2 * SurePanel.transform.position.x - player.position.x, SurePanel.transform.position.y, 2 * SurePanel.transform.position.z - player.position.z));                   
            ModeMenu(true);
        }

        // Activer/désactiver l'effet de flou
       // if (postProcessVolume != null)
       // {
           // postProcessVolume.enabled = !postProcessVolume.enabled;
       // }

        // Mettez ici d'autres actions que vous souhaitez effectuer lors de la pause
    }


}
