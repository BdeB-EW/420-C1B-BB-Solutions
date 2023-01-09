using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CouleurCube : MonoBehaviour
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
}
