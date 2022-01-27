using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Classe qui détecte quand le cube approche de cet objet.
 * On affiche un message dans la console
 * 
 * Auteurs: Enseignants du cours de 420-C1B-BB
 */

public class DetectionCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Mini-cube: Allo !");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Mini-cube: Bye !");
    }
}
