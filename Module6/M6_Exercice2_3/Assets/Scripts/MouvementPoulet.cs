using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementPoulet : MonoBehaviour
{
    public Vector3 destination;
    public float vitesse;

    private GameObject _renard;
    private Vector3 _positionInitiale;
    private Animator _animator;


    private AudioSource _audioSource;


    // Start is called before the first frame update
    void Start()
    {
        _renard = GameObject.Find("Renard");
        _positionInitiale = transform.position;
        _animator = GetComponent<Animator>();


        _audioSource = GetComponent<AudioSource>();
    
    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = destination - transform.position;
        transform.LookAt(destination);

        Vector3 deplacement = direction.normalized * vitesse * Time.deltaTime;

        // Est-ce qu'on est proche du renard ?
        if (Vector3.Distance(transform.position, _renard.transform.position) < 10.0f)
        {
            deplacement *= 2;
            _animator.SetBool("Courir", true);
        }
        else
        {
            _animator.SetBool("Courir", false);
        }
        transform.position += deplacement;

        // Est-ce qu'on est arrivé à destination ? Si, on change de destination
        if (Vector3.Distance(transform.position, destination) < 0.1f)
        {
            _audioSource.Play();

            destination = _positionInitiale;
            _positionInitiale = transform.position;
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _renard)
        {
            GameObject.Find("ControleurJeu").GetComponent<GameManager>().PouleDevoree();
            Destroy(gameObject);
        }
    }
}
