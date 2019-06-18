using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Director : MonoBehaviour
{
    public NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {
        // If left mouse is down
        if (Input.GetMouseButtonDown(0))
        {
            // Perform raycast using camera
            Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(camRay, out hit))
            {
                // Get agent to go to hit point
                agent.SetDestination(hit.point);
            }
        }
    }
}