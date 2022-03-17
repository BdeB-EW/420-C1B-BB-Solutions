using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrouille : MonoBehaviour
{
    [SerializeField] private Transform[] objectifs;
    private NavMeshAgent agentAI;
    private int indiceObjectifs;

    // Start is called before the first frame update
    void Start()
    {
        agentAI = GetComponent<NavMeshAgent>();
        indiceObjectifs = 0;
        agentAI.SetDestination(objectifs[indiceObjectifs].position);
    }

    // Update is called once per frame
    void Update()
    {
        if(agentAI.remainingDistance <= agentAI.stoppingDistance)
        {
            indiceObjectifs = (indiceObjectifs + 1) % objectifs.Length;
            agentAI.SetDestination(objectifs[indiceObjectifs].position);
            Debug.Log(indiceObjectifs);
        }
        
    }
}
