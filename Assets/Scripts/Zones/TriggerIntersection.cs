using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerIntersection : MonoBehaviour
{
    [SerializeField] string tagFilter;
    [SerializeField] UnityEvent onTriggerEnter;
    [SerializeField] UnityEvent onTriggerExit;
    public Boolean is_occupied;
    public Boolean can_move;
    public Boolean will_move_right;
    public Boolean will_move_left;

    public void Start(){
        is_occupied = false;
        can_move = true;
        will_move_right = false;
        will_move_left = false;
    }
    
    public void OnTriggerEnter(Collider obj)
    {
        if(!obj.gameObject.CompareTag(tagFilter)) return;
        onTriggerEnter.Invoke();
        is_occupied = true;
    }
    public void OnTriggerExit(Collider obj)
    {
        if(!obj.gameObject.CompareTag(tagFilter)) return;
        onTriggerEnter.Invoke();
        is_occupied = false;
    }

}
