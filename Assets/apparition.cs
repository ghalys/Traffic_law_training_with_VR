using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class apparition : MonoBehaviour
{
    
    [SerializeField] string tagFilter;
    [SerializeField] UnityEvent onTriggerEnter;
    
    public void OnTriggerEnter(Collider obj)
    {
        if(!obj.gameObject.CompareTag(tagFilter)) return;
        onTriggerEnter.Invoke();
    }
    
}
