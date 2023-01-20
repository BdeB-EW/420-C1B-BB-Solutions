using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Classe qui déplace le cube vers le haut quand le joueur arrive près.
 * 
 * Auteurs: Enseignants de 420-1CB-BB
 */
public class DetecteurCube : MonoBehaviour
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
        transform.position += new Vector3(0, 3, 0);
    }
}
