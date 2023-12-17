using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCar : MonoBehaviour
{
    public Transform waypointsContainer;

    private List<GameObject> waypoints;
    public float speed = 10;
    public float mindist = 2;
    private int index = 0;
    public bool can_move = false;

    void Start()
    {
        waypoints = new List<GameObject>(); 
        if (waypointsContainer != null)
        {
            foreach (Transform child in waypointsContainer)
            {
                waypoints.Add(child.gameObject);
            }
        }

    }
    public void Can_move(){
        can_move = !can_move;
    }
    void Update()
    {  
         if(can_move)
    {
        

        MoveToWaypoint();
        RotateTowardsWaypoint();
    }
    }

    void MoveToWaypoint()
    {
        Vector3 destination = waypoints[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        transform.position = newPos;
        float distance = Vector3.Distance(transform.position, destination);
        if (distance <= mindist)
        {
            if (index < waypoints.Count - 1)
            {
                index++;
            }
            else if (index == waypoints.Count-1)
            {
                can_move = false;
            }
        }
    }

    void RotateTowardsWaypoint()
    {
        if (index < waypoints.Count)
        {
            Vector3 direction = waypoints[index].transform.position - transform.position;
            Quaternion toRotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, Time.deltaTime * speed);
        }
    }
}
