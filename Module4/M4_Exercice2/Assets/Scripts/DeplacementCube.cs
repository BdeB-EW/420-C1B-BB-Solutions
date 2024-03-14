using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementCube : MonoBehaviour
{
    public Transform _plan;
    public float _vitesse = 5f;

    private float _limiteX;
    private float _limiteZ;
 
    void Start()
    {
        _limiteX = _plan.localScale.x * 5 - transform.localScale.x / 2;
        _limiteZ = _plan.localScale.z * 5 - transform.localScale.z / 2;
    }

    // Update is called once per frame
    void Update()
    {
        float deplacementHorizontal = Input.GetAxis("Horizontal") * _vitesse * Time.deltaTime;
        float deplacementVertical = Input.GetAxis("Vertical") * _vitesse * Time.deltaTime;

        Vector3 deplacement = new Vector3(deplacementHorizontal, 0, deplacementVertical);
        Vector3 nouvellePosition = transform.position + deplacement;

        if (nouvellePosition.x > -_limiteX && nouvellePosition.x < _limiteX &&
            nouvellePosition.z > -_limiteZ && nouvellePosition.z < _limiteZ)
        {
            transform.position = nouvellePosition;
        }
    }
}
