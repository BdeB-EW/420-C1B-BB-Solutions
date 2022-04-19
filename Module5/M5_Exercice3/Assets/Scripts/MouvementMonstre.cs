using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Classe qui illustre le fonctionnement du NavMesh Navigator
/// 
/// Auteurs: Enseignants du cours de 420-C1B-BB
/// </summary>
public class MouvementMonstre : MonoBehaviour
{
    [SerializeField] private GameObject destination;

    /// <summary>
    /// L'agent pour déplacer le monstre.
    /// </summary>
    private NavMeshAgent agentAI;

    void Start()
    {


        agentAI = GetComponent<NavMeshAgent>();
        agentAI.SetDestination(destination.transform.position);





    }

    void Update()
    {
    }
}
