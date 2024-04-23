using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Utilitaires
{
    public static GameObject TrouverObjetClique(Vector3 positionSouris)
    {
        GameObject objectClique = null;
        Ray ray = Camera.main.ScreenPointToRay(positionSouris);
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(ray, out hit))
        {
            objectClique = hit.collider.gameObject;
        }
        return objectClique;
    }

    public static Vector3 TrouverPointClique(Vector3 positionSouris)
    {
        Vector3 pointClique = positionSouris;
        Ray ray = Camera.main.ScreenPointToRay(positionSouris);
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(ray, out hit))
        {
            pointClique = hit.point;
        }
        return pointClique;
    }
        
    
}

