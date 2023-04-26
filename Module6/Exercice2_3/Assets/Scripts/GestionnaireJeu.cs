using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionnaireJeu : MonoBehaviour
{
    [SerializeField] private GameObject prefabSandwich;
    
    [SerializeField] private TMP_Text txtManges;
    [SerializeField] private TMP_Text txtRestants;
    [SerializeField] private float distanceMinimum;

    private AudioSource sonSandwich;
    private GameObject gourmand;

    
    private int nbSandwichsManges = 0;
    private int nbSandwichsRestants = 0;

    private int nombreEssaisMax = 20; // Le nombre d'essai maximal pour essayer de placer un sandwich

    void Start()
    {

        sonSandwich = GameObject.Find("Crounch").GetComponent<AudioSource>();
        gourmand = GameObject.Find("Gourmand");

        for (int i=0; i<5; i++)
        {
            CreerSandwich();
        }

    }

    
    void Update()
    {
        if (nbSandwichsManges > 1)
        {
            txtManges.text = nbSandwichsManges + " sandwichs mangés";
        }
        else
        {
            txtManges.text = nbSandwichsManges + " sandwich mangé";
        }

        if (nbSandwichsRestants > 1)
        {
            txtRestants.text = nbSandwichsRestants + " sandwichs à manger";
        }
        else
        {
            txtRestants.text = nbSandwichsRestants + " sandwich à manger";
        }
    }

    public void MangerSandwich(GameObject unSandwich)
    {
        sonSandwich.Play();
        Destroy(unSandwich);
        nbSandwichsManges++;
        nbSandwichsRestants--;
    }

    public void CreerSandwich()
    {
        for (int i=0; i<nombreEssaisMax; i++)
        {
            Vector3 position = GenererPositionAleatoire();

            if (EstPositionValide(position))
            {
                Instantiate(prefabSandwich, position, Quaternion.identity);
                nbSandwichsRestants++;
                break;
            }
        }
        Debug.Log("Aucun endroit valide pour un nouveau sandwich");
    }

    public Vector3 GenererPositionAleatoire()
    {
        float x = Random.Range(-12f, 12f);
        float y = 2.0f;
        float z = Random.Range(-12f, 12f);
        Vector3 position = new Vector3(x, y, z);
        return position;
    }

    public bool EstPositionValide(Vector3 position)
    {
        bool valide = true;
        
        float distanceJoueur = Vector3.Distance(position, gourmand.transform.position);

        if (distanceJoueur < distanceMinimum)
        {
            valide = false;
        }
        else
        {
            GameObject[] sandwichs = GameObject.FindGameObjectsWithTag("Sandwich");
            for (int i=0; i<sandwichs.Length; i++)
            {
                float distanceSandwich = Vector3.Distance(position, sandwichs[i].transform.position);
                if (distanceSandwich < distanceMinimum)

                {
                    valide = false;
                    break;
                }
            }

        }

        return valide;
    }
}
