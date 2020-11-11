using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoint : MonoBehaviour
{
    public GameObject[] waypoints;
    int current = 0;
    public float speed;
    float WPradius = 1;

    void Update()
    {

        //se hvis objekt er inahedde at waypoints så den kan få et ny waypoints at går efter
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
        {
            current = Random.Range(0, waypoints.Length);
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }
        //får en objekt til at beværse sig 
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);

    }
}
