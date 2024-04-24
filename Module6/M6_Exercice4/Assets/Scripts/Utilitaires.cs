using UnityEngine;

public class Utilitaires
{
    /// <summary>
    /// Retourne l'objet cliqu� par la souris
    /// </summary>
    /// <param name="positionSouris">La position de la souris</param>
    /// <returns>L'objet cliqu�. null si aucun objet n'a �t� cliqu�</returns>
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
    /// M�thode qui retourne le point o� un objet est cliqu�.
    /// 
    /// Si aucun objet n'a �t� cliqu�, on retourne la position de la souris
    /// </summary>
    /// <param name="positionSouris">La position de la souris qu'il faut convertir</param>
    /// <returns>Le point o� on a cliqu� en 3D</returns>
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

