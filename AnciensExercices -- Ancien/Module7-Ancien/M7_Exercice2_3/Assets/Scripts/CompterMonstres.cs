using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Classe qui compte le nombre de monstres en jeu.
/// Quand il n'y a plus de monstre, la sc�ne de victoire est affich�e.
/// 
/// Auteur: Enseignants de 420-1CB-BB
/// </summary>
public class CompterMonstres : MonoBehaviour
{

    /// <summary>
    /// Le nombre de monstres
    /// </summary>
    private int nombreMonstres;
    void Start()
    {
        GameObject[]  monstres = GameObject.FindGameObjectsWithTag("Monstre");
        nombreMonstres = monstres.Length;
        Debug.Log("Il y a " + monstres.Length + " monstres");
    }
    /// <summary>
    /// M�thode qu'on doit appeler quand un monstre est attrap�.
    /// 
    /// Lorsqu'il n'y a plus de monstre, on affiche la sc�ne de victoire
    /// </summary>
    public void RetirerMonstre()
    {
        nombreMonstres--;

        if (nombreMonstres == 0)
        {
            SceneManager.LoadScene("Victoire");
        }
    }
}
