using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandwich : MonoBehaviour
{
    float vitesseRotation = 100f;

    void Update()
    {
        float angle = vitesseRotation * Time.deltaTime;
        transform.Rotate(Vector3.up, angle);
    }
}
