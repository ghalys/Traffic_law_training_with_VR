
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
public class PedestrianControl : MonoBehaviour

{
    public NavMeshAgent agent;
    public Animator animator;

    public GameObject path;
    private Transform[] PathPoints;
    public int index = 0;
    public float minimum_distance;
    public bool iswalking;
    public float force = 5f; // Force à appliquer pour déplacer l'objet
    private Rigidbody rb;


    public void Start(){
        agent  = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;

        iswalking = true;

        PathPoints = new Transform[path.transform.childCount];
        for (int i=0 ; i< PathPoints.Length; i++){
            PathPoints[i]= path.transform.GetChild(i);
        }
    }
    void Update()
    {
        if(iswalking){
         roam();

        }
    }
    void roam()
    {
        Debug.Log(Vector3.Distance(transform.position,PathPoints[index].position));
        
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

    void OnCollisionEnter(Collision collision)
    {
        // Vérifiez si la collision a eu lieu avec la voiture
        if (collision.gameObject.tag == "Vehicle")
        {
            iswalking =false;
            agent.enabled = false;
            rb.isKinematic = false;

           
             // Calculez la direction dans laquelle déplacer l'objet (dans cet exemple, vers l'avant de la voiture)
            Vector3 direction = collision.contacts[0].point - transform.position;
            direction = direction.normalized;
            direction.y=0;
            rb.AddForce(direction * force, ForceMode.Impulse);

        }
    }
}
