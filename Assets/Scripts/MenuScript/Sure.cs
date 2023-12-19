using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sure : MonoBehaviour
{
    public GameObject Pause ;
    public GameObject Suree ;

    public void Non() 
    {
        Suree.SetActive(false) ;
        Pause.SetActive(true) ;
    }
}
