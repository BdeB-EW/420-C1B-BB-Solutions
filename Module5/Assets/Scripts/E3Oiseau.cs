using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E3Oiseau : MonoBehaviour
{
    [SerializeField] private float vitesseMarcher = 10f;
    [SerializeField] private float vitesseTourner = 120f;

    private CharacterController ctrlPersonnage;
    
    void Start()
    {
        ctrlPersonnage = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Rotation du personnage
        float rotation = Input.GetAxis("Horizontal") * vitesseTourner * Time.deltaTime;
        transform.Rotate(Vector3.up, rotation);


        // Déplacement du personnage
        float vertical = Input.GetAxis("Vertical") * vitesseMarcher * Time.deltaTime;
        Vector3 deplacement = new Vector3(0, 0, vertical);
        deplacement = transform.TransformDirection(deplacement);
        ctrlPersonnage.Move(deplacement);

        // Application de la gravité
        Vector3 descendre = Vector3.down * 9.81f * Time.deltaTime;
        ctrlPersonnage.Move(descendre);
    }
}
