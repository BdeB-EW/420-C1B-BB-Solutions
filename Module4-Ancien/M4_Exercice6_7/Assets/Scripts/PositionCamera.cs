using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe qui positionne la caméra dans quatre positions et directions différentes.
/// L'exercice sert à montrer l'utilité des tableaux. Le code en commentaire est une version sans tableaux
/// 
/// Auteurs: Enseignants du cours de 420-C1B-BB
/// 
/// </summary>
public class PositionCamera : MonoBehaviour
{
    //[SerializeField] private Vector3 positionCamera0;
    //[SerializeField] private Vector3 positionCamera1;
    //[SerializeField] private Vector3 positionCamera2;
    //[SerializeField] private Vector3 positionCamera3;

    //[SerializeField] private Vector3 rotationCamera0;
    //[SerializeField] private Vector3 rotationCamera1;
    //[SerializeField] private Vector3 rotationCamera2;
    //[SerializeField] private Vector3 rotationCamera3;

    [SerializeField] private Vector3[] tabPositions;
    [SerializeField] private Vector3[] tabRotations;

    private int positionActiveCamera;

    // Start is called before the first frame update
    void Start()
    {
        positionActiveCamera = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            positionActiveCamera = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            positionActiveCamera = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            positionActiveCamera = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            positionActiveCamera = 3;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            positionActiveCamera = positionActiveCamera + 1;
            if (positionActiveCamera == 4)
            {
                positionActiveCamera = 0;
            }
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = tabPositions[positionActiveCamera];
        transform.eulerAngles = tabRotations[positionActiveCamera];

        //if (positionActiveCamera == 0)
        //{
        //    transform.position = positionCamera0;
        //    transform.eulerAngles = rotationCamera0; 
        //}
        //else if (positionActiveCamera == 1)
        //{
        //    transform.position = positionCamera1;
        //    transform.eulerAngles = rotationCamera1;
        //}
        //else if (positionActiveCamera == 2)
        //{
        //    transform.position = positionCamera2;
        //    transform.eulerAngles = rotationCamera2;
        //}
        //else if (positionActiveCamera == 3)
        //{
        //    transform.position = positionCamera3;
        //    transform.eulerAngles = rotationCamera3;
        //}
    }
}
