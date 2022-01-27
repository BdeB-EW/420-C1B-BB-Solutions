using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Classe qui montre comment placer un objet en utilisant le transform du GameObject
 * 
 * Auteurs: ENseignants du cours de 420-C1B-BB
 */
public class CubeBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Place l`objet de jeu à la position (0, 1, 0)
        transform.localPosition = new Vector3(0, 1, 0);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
