using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surveillance : MonoBehaviour
{
    private Vector3[] positions;
    private Vector3[] rotations;

    private int cameraActive;

    void Start()
    {
        positions = new Vector3[4];
        rotations = new Vector3[4];

        // Configuration des caméras
        positions[0] = new Vector3(0f, 4f, -7f);
        rotations[0] = new Vector3(30f, 0f, 0f);

        positions[1] = new Vector3(-7f, 4f, 0f);
        rotations[1] = new Vector3(30f, 90f, 0f);

        positions[2] = new Vector3(0f, 4f, 7f);
        rotations[2] = new Vector3(30f, 180f, 0f);

        positions[3] = new Vector3(7f, 4f, 0f);
        rotations[3] = new Vector3(30f, 270f, 0f);

        // Sélection de la première caméra (caméra 0)
        cameraActive = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cameraActive = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cameraActive = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            cameraActive = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            cameraActive = 3;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            // Passage à la prochaine caméra
            cameraActive++;
            if (cameraActive == 4)
            {
                cameraActive = 0;
            }
        }

        // Activation de la caméra active
        transform.position = positions[cameraActive];
        transform.eulerAngles = rotations[cameraActive];
    }
}
