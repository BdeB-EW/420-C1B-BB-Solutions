using UnityEngine;
using UnityEngine.AI;

public class BougerCubeAI : MonoBehaviour
{
    private NavMeshAgent _agent;
    private GameObject _plan;

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _plan = GameObject.Find("Plane");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 positionSouris = Input.mousePosition;

            if (Utilitaires.TrouverObjetClique(positionSouris) == _plan)
            {
                Vector3 pointClique = Utilitaires.TrouverPointClique(positionSouris);
                _agent.SetDestination(pointClique);
            }
        }
    }
}
