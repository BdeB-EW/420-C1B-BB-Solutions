using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Classe qui place l'objet à une des trois positions spécifiées dans l'inspecteur.
 * L'endroit est déterminé au hasard.
 *
 * Auteurs: Enseignants de 420-1CB-BB
 */
public class CacherCube : MonoBehaviour
{
    [SerializeField] private Vector3 cachette1; // La première cachette
    [SerializeField] private Vector3 cachette2; // La deuxième cachette
    [SerializeField] private Vector3 cachette3; // La troisième cachette

    // Start is called before the first frame update
    void Start()
    {
        // Détermine une cachette aléatoire
        int valeurAleatoire = UnityEngine.Random.Range(1, 4);
        Debug.Log(valeurAleatoire);

        // On fait un if pour placer l'élément à la bonne place
        if (valeurAleatoire == 1)
        {
            transform.position = cachette1;
        }
        else if (valeurAleatoire == 2)
        {
            transform.position = cachette2;
        }
        else if (valeurAleatoire == 3)
        {
            transform.position = cachette3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
