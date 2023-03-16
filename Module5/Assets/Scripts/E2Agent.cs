using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class E2Agent : MonoBehaviour
{
    [SerializeField] private Transform[] pointsNavigation = new Transform[5];

    private NavMeshAgent agentIA;
    private int destination;

    void Start()
    {
        agentIA = GetComponent<NavMeshAgent>();

        // dirige l'agent vers la première destination
        destination = 0;
        agentIA.SetDestination(pointsNavigation[destination].position);
    }

    void Update()
    {
        if (!agentIA.pathPending && (agentIA.remainingDistance <= agentIA.stoppingDistance))
        {
            // destination atteinte, on passe à la prochaine destination
            destination++;
            if (destination == pointsNavigation.Length)
            {
                destination = 0;
            }

            agentIA.SetDestination(pointsNavigation[destination].position);
        }
    }
}
