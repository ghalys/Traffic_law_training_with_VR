using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Apparition : MonoBehaviour
{
    
    [SerializeField] string tagFilter;
    
    [SerializeField] UnityEvent onTriggerEnter;
    [SerializeField] UnityEvent onTriggerExit;
    public void OnTriggerEnter(Collider obj)
    {
        if(!obj.gameObject.CompareTag(tagFilter)) return;
        onTriggerEnter.Invoke();
    }
    public void OnTriggerExit(Collider obj)
    {
        if (!obj.gameObject.CompareTag(tagFilter)) return;
        onTriggerExit.Invoke();
    }

}
