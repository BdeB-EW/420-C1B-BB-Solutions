using UnityEngine;
using UnityEngine.AI;

public class MouvementPoulet : MonoBehaviour
{
    private GameObject _renard;
    private Animator _animator;
    private float _vitesse;

    private AudioSource _cocorico;
    private NavMeshAgent _agent;
    private GameManager _gameManager;


    // Start is called before the first frame update
    void Start()
    {
        _renard = GameObject.Find("Renard");
        _animator = GetComponent<Animator>();
        _cocorico = GetComponent<AudioSource>();
        _gameManager = GameObject.Find("ControleurJeu").GetComponent<GameManager>();
        _agent = GetComponent<NavMeshAgent>();
        _vitesse = _agent.speed;
        _agent.destination = _gameManager.ObtenirNouvelleDestination();
    }

    public void ChangerDestination(Vector3 destination)
    {
        _agent.destination = destination;
        _cocorico.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, _renard.transform.position) < 10.0f)
        {
            _agent.speed = _vitesse * 2;
            _animator.SetBool("Courir", true);
        }
        else
        {
            _agent.speed = _vitesse;
            _animator.SetBool("Courir", false);
        }

        if (! _agent.pathPending && _agent.remainingDistance < 0.2f)
        {
            Vector3 destination = _gameManager.ObtenirNouvelleDestination();
            ChangerDestination(destination);
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _renard)
        {
            _gameManager.PouleDevoree();
            Destroy(gameObject);
        }
    }
}
