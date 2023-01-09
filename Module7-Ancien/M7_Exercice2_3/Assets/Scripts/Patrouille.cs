using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Classe qui illustre comment faire une patrouille sur un objet
/// 
/// Auteurs: Enseignants de 420-C1B-BB
/// </summary>
public class Patrouille : MonoBehaviour
{
    /// <summary>
    /// Les objetifs de la patrouille
    /// </summary>
    [SerializeField] private Transform[] objectifs;
    
    /// <summary>
    /// L'indice dans le tableau d'objectifs
    /// </summary>
    private int indiceObjectifs;

    /// <summary>
    /// L'agent pour déplacer l'objet de jeu
    /// </summary>
    private NavMeshAgent agentAI;

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
        // Vérifie si on est rendu au point de destination.
        // Il faut également s'assurer que l'agent n'est pas en train de calculer un
        // nouveau chemin d'où le ! agentAI.pathPending  
        if (! agentAI.pathPending && agentAI.remainingDistance <= agentAI.stoppingDistance)
        {
            indiceObjectifs = (indiceObjectifs + 1) % objectifs.Length;
            agentAI.SetDestination(objectifs[indiceObjectifs].position);
//            Debug.Log(indiceObjectifs);
        }        
    }
}
