using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerCouleur : MonoBehaviour
{
    public void PeindreRouge()
    {
        Material materiel = GetComponent<MeshRenderer>().material;
        materiel.color = Color.red;
    }

    public void PeindreJaune()
    {
        Material materiel = GetComponent<MeshRenderer>().material;
        materiel.color = Color.yellow;
    }

    public void PeindreVert()
    {
        Material materiel = GetComponent<MeshRenderer>().material;
        materiel.color = Color.green;
    }

    /** Cette m�thode a un param�tre et on peut en donner la valeur dans Unity
     */
    public void Peindre(int couleur)
    {
        Material materiel = GetComponent<MeshRenderer>().material;
        if (couleur == 1)
        {
            materiel.color = Color.red;
        }
        else if (couleur == 2)
        {
            materiel.color = Color.yellow;
        }
        else if (couleur == 3)
        {
            materiel.color = Color.green;
        }
    }
}