using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCube : MonoBehaviour
{
    [SerializeField] private Vector3 axeRotation;
    [SerializeField] private float vitesseRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = vitesseRotation * Time.deltaTime;
        transform.Rotate(axeRotation, angle);
    }
}
