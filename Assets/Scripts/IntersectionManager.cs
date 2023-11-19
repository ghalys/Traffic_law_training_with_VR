using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntersectionManager : MonoBehaviour
{
    public List<TriggerIntersection> roads = new List<TriggerIntersection>();

    void Start()
    {
    }
    void update()
    {
       for (int i = 0; i < roads.Count-1; i++)
        {
            roads[i].can_move = !roads[i+1].is_occupied;

        }
}
}
