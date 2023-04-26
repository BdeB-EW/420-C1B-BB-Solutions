using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraiterSouris : MonoBehaviour
{
    [SerializeField] private GameObject leCube;
    [SerializeField] private GameObject laSphere;
    [SerializeField] private GameObject laCapsule;
    [SerializeField] private GameObject lePlan;


    // Update is called once per frame
    void Update()
    {
//        Debug.Log("Position souris: " + Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            GameObject objetClique = Utilitaires.TrouverObjetClique(Input.mousePosition);
            if (objetClique != null && objetClique != lePlan)
            {
                MonterObjet(objetClique);
            }
            else
            {
                Vector3 pointClique = Utilitaires.TrouverPointClique(Input.mousePosition);
                if (pointClique != Input.mousePosition)
                {
                    ChangerValeurZ(leCube, pointClique.z);
                    ChangerValeurZ(laSphere, pointClique.z);
                    ChangerValeurZ(laCapsule, pointClique.z);
                }
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            GameObject objetClique = Utilitaires.TrouverObjetClique(Input.mousePosition);
            if (objetClique != null && objetClique != lePlan)
            {
                DescendreObjet(objetClique);
            }
        }
    }

    private void MonterObjet(GameObject obj)
    {
        Vector3 positionObjet = obj.transform.position;
        positionObjet.y += 1;
        obj.transform.position = positionObjet;
    }

    private void DescendreObjet(GameObject obj)
    {
        Vector3 positionObjet = obj.transform.position;
        positionObjet.y -= 1;
        obj.transform.position = positionObjet;
    }

    private void ChangerValeurZ(GameObject obj, float nouveauZ)
    {
        Vector3 positionObjet = obj.transform.position;
        positionObjet.z = nouveauZ;
        obj.transform.position = positionObjet;
    }
}
