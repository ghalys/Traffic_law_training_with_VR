using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SignalFailure : MonoBehaviour
{
    public Clignotant clignotant;
    public FailMenu fail_menu;
    public void CheckLeftSignal()
    {
        if (!clignotant.clignotantActif)
        {
            fail_menu.gameObject.SetActive(true);
            fail_menu.SetMessageNoLeftSignal();
        }
    }
    
}
