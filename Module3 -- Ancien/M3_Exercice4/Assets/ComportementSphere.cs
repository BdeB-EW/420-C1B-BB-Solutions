using UnityEngine;

public class ComportementSphere : MonoBehaviour
{
    public float facteurAgrandissement;
    public float tempsChangement;

    private float tempsEcoule;

    // Start is called before the first frame update
    void Start()
    {
        tempsEcoule = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tempsEcoule += Time.deltaTime;
        if (tempsEcoule >= tempsChangement)
        {
            facteurAgrandissement = -facteurAgrandissement;
            tempsEcoule = 0;
        }
        transform.localScale += facteurAgrandissement * Vector3.one * Time.deltaTime; // Vector3.one = (1, 1, 1)
    }



    void Truc()
    {
        int valeur1;
        int valeur2;
        int valeur3;
        int valeur4;
        int valeur5;
        int valeur6;
        int valeur7;
        int valeur8;
        int valeur9;
        int valeur10;





    }
}
