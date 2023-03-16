using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class E1Agent : MonoBehaviour
{
    [SerializeField] private GameObject destination;
    private NavMeshAgent agentIA;

    void Start()
    {
        agentIA = GetComponent<NavMeshAgent>();
        agentIA.SetDestination(destination.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
