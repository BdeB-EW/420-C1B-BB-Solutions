using UnityEngine;
using UnityEngine.AI;

public class BougerCubeAI : MonoBehaviour
{
    private NavMeshAgent _agent;
    private Transform _destination;

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _destination = GameObject.Find("Destination").transform;
        _agent.SetDestination(_destination.position);
    }
}
