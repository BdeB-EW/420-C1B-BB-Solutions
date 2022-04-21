using UnityEngine;

public class Utilitaires
{
    /// <summary>
    /// Retourne l'objet cliqué par la souris
    /// </summary>
    /// <param name="positionSouris">La position de la souris</param>
    /// <returns>L'objet cliqué. null si aucun objet n'a été cliqué</returns>
    public static GameObject TrouverObjetClique(Vector3 positionSouris)
    {
        GameObject objetClique = null;
        Ray ray = Camera.main.ScreenPointToRay(positionSouris);
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(ray, out hit))
        {
            objetClique = hit.collider.gameObject;
        }
        return objetClique;
    }

    /// <summary>
    /// Méthode qui retourne le point où un objet est cliqué.
    /// 
    /// Si aucun objet n'a été cliqué, on retourne la position de la souris
    /// </summary>
    /// <param name="positionSouris">La position de la souris qu'il faut convertir</param>
    /// <returns>Le point où on a cliqué en 3D</returns>
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




