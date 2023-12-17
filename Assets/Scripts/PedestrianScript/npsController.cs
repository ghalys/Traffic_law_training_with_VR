using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class npsController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Animator animator;

    public GameObject path;
    private Transform[] PathPoints;
    public int index = 0;
    public float minimum_distance;

    public void Start(){
        agent  = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        PathPoints = new Transform[path.transform.childCount];
        for (int i=0 ; i< PathPoints.Length; i++){
            PathPoints[i]= path.transform.GetChild(i);
        }
    }
    void Update()
    {
        roam();
    }
    void roam()
    {
        
        if (Vector3.Distance(transform.position,PathPoints[index].position) < minimum_distance){
            if (index + 1 != PathPoints.Length){

            
            index +=1;
            }
            else{
                index =0;
            }
        }
        agent.SetDestination(PathPoints[index].position);
    }
}
