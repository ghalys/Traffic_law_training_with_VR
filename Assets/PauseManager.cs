using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//using UnityEngine.Rendering.PostProcessing;

public class PauseManager : MonoBehaviour
{
    public InputAction pauseAction;
    public GameObject pausePanel;

    public Transform player;

    public float spawnDistance = 2 ;

    public float hauteur = 2 ;

    public bool ispaused=true ;
    public List<GameObject> listeDeGameObjects;

    
    public GameObject body ;

    public GameObject components ;
    public GameObject Board ;

    public GameObject wheel1 ;
    public GameObject wheel2 ;

    public GameObject wheel3 ;

    public GameObject wheel4 ;



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
        listeDeGameObjects = new List<GameObject>();
        listeDeGameObjects.Add(GameObject.Find("Board"));
        listeDeGameObjects.Add(GameObject.Find("wheel1"));
        listeDeGameObjects.Add(GameObject.Find("wheel2"));
        listeDeGameObjects.Add(GameObject.Find("wheel3"));
        listeDeGameObjects.Add(GameObject.Find("wheel4"));
    }

    void OnPause(InputAction.CallbackContext context)
    {
        if (ispaused)
        {
            // Activer/désactiver le panneau Pause
            pausePanel.SetActive(false);
            ispaused = false;
            Time.timeScale = 1;
            wheel1.SetActive(true) ;
            wheel2.SetActive(true) ;
            wheel3.SetActive(true) ;
            wheel4.SetActive(true) ;
            body.SetActive(true) ;
            components.SetActive(true) ;
            Board.SetActive(true) ;
            
        }
        else 
        {
            // Activer/désactiver le panneau Pause
            pausePanel.SetActive(true);
            ispaused = true;
            Time.timeScale = 0;
            pausePanel.transform.position=player.position + new Vector3(player.forward.x,hauteur,player.forward.z).normalized*spawnDistance ;
            pausePanel.transform.LookAt(new Vector3(2 * pausePanel.transform.position.x - player.position.x, pausePanel.transform.position.y, 2 * pausePanel.transform.position.z - player.position.z));
            wheel1.SetActive(false) ;
            wheel2.SetActive(false) ;
            wheel3.SetActive(false) ;
            wheel4.SetActive(false) ;
            body.SetActive(false) ;
            components.SetActive(false) ;
            Board.SetActive(false) ;
        }

        // Activer/désactiver l'effet de flou
       // if (postProcessVolume != null)
       // {
           // postProcessVolume.enabled = !postProcessVolume.enabled;
       // }

        // Mettez ici d'autres actions que vous souhaitez effectuer lors de la pause
    }
}
