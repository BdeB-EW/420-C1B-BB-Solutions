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

    private Quaternion[] tabRotations;

    private int positionActiveCamera;

    private int hauteurCamera = 1;

    // Start is called before the first frame update
    void Start()
    {
        positionActiveCamera = 0;
        tabRotations = new Quaternion[4];

        for (int i = 0; i < tabPositions.Length; i++)
        {
            Vector3 direction = Vector3.zero - tabPositions[i];
            tabRotations[i] = Quaternion.LookRotation(direction);
        }
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

        if (Input.GetKeyDown (KeyCode.PageUp) && hauteurCamera < 10)
        {
            hauteurCamera++;
            for (int i=0; i<tabPositions.Length; i++)
            {
                tabPositions[i] += Vector3.up;
                Vector3 direction = Vector3.zero - tabPositions[i];
                tabRotations[i] = Quaternion.LookRotation(direction);
            }
        }

        if (Input.GetKeyDown(KeyCode.PageDown) && hauteurCamera > 1)
        {
            hauteurCamera--;
            for (int i = 0; i < tabPositions.Length; i++)
            {
                tabPositions[i] += Vector3.down;
                Vector3 direction = Vector3.zero - tabPositions[i];
                tabRotations[i] = Quaternion.LookRotation(direction);
            }
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = tabPositions[positionActiveCamera];
        transform.rotation = tabRotations[positionActiveCamera];

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
