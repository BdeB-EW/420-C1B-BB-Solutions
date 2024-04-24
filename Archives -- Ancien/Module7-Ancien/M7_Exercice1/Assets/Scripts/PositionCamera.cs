using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe qui positionne la caméra dans quatre positions et directions différentes.
/// Il est possible de monter et descendre la caméra. Les rotations sont recalculées à
/// chaque fois.
/// 
/// Auteurs: Enseignants du cours de 420-C1B-BB
/// 
/// </summary>
public class PositionCamera : MonoBehaviour
{
    [SerializeField] private Vector3[] tabPositions;
    private Quaternion[] tabRotations;
    private int positionActiveCamera;
    private int hauteurCamera = 1;

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
    void LateUpdate()
    {
        transform.position = tabPositions[positionActiveCamera];
        transform.rotation = tabRotations[positionActiveCamera];
    }
}
