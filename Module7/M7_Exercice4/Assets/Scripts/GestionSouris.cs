using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Classe d'exemple sur la gestion de la souris
/// 
/// Auteurs: Enseignants de 420-C1B-BB
/// </summary>
public class GestionSouris : MonoBehaviour
{
    [SerializeField] private Text textPositionSouris;

    [SerializeField] private GameObject[] lesObjets;

    [SerializeField] private GameObject plan;

    // Start is called before the first frame update
    void Start()
    {
        textPositionSouris.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        AfficherPositionSouris();

        if (Input.GetMouseButtonDown(0))
        { 
            GameObject objetClique = Utilitaires.TrouverObjetClique(Input.mousePosition);
            if (objetClique != null && EstDansTableau(objetClique))
            {
                objetClique.transform.position += Vector3.up;
            } 
            
            if (objetClique == plan)
            {
                Vector3 pointClique = Utilitaires.TrouverPointClique(Input.mousePosition);
                DeplacerObjets(pointClique);
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            GameObject objetClique = Utilitaires.TrouverObjetClique(Input.mousePosition);
            if (objetClique != null && EstDansTableau(objetClique))
            {
                objetClique.transform.position += Vector3.down;
            }
        }
    }

    private void AfficherPositionSouris()
    {
        Vector3 positionSouris = Input.mousePosition;
        textPositionSouris.text = "X: " + positionSouris.x + " Y: " + positionSouris.y;
    }

    public bool EstDansTableau(GameObject objetCherche)
    {
        bool present = false;
        for (int i = 0; i < lesObjets.Length && ! present; i++)
        {
            if (lesObjets[i] == objetCherche)
            {
                present = true;
            }
        }
        return present;
    }

    public void DeplacerObjets(Vector3 pointClique)
    {
        float positionz = pointClique.z;

        for (int i=0; i < lesObjets.Length; i++)
        {
            Vector3 positionActuelle = lesObjets[i].transform.position;
            Vector3 nouvellePosition = positionActuelle + Vector3.forward * (pointClique.z - positionActuelle.z);
            lesObjets[i].transform.position = nouvellePosition;
        }
    }

}











///// <summary>
///// Retourne l'objet qui est cliqué. Retourne null si le clic n'a touché aucun objet.
///// Les objets doivent avoir un Collider.
///// </summary>
///// <param name="positionSouris">La position de la souris</param>
///// <returns>L'objet cliqué ou null</returns>
//public GameObject TrouverObjetClique(Vector3 positionSouris)
//{
//    GameObject objetClique = null;  // On retourne null si on ne trouve rien

//    // Trace une ligne de la position de la caméra jusqu'au point cliqué
//    // Remet dans un monde 3D
//    Ray ray = Camera.main.ScreenPointToRay(positionSouris);

//    RaycastHit hit = new RaycastHit();

//    if (Physics.Raycast(ray, out hit))
//    {
//        objetClique = hit.collider.gameObject;
//    }
//    return objetClique;
//}
