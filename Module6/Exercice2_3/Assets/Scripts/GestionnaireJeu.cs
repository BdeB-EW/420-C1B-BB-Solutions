using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionnaireJeu : MonoBehaviour
{
    [SerializeField] private GameObject prefabSandwich;
    
    [SerializeField] private TMP_Text txtManges;
    [SerializeField] private TMP_Text txtRestants;

    private AudioSource sonSandwich;

    
    private int nbSandwichsManges = 0;
    private int nbSandwichsRestants = 0;

    void Start()
    {

        sonSandwich = GameObject.Find("Crounch").GetComponent<AudioSource>();

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
        float x = Random.Range(-12f, 12f);
        float y = 2.0f;
        float z = Random.Range(-12f, 12f);

        Vector3 position = new Vector3(x, y, z);

        GameObject.Instantiate(prefabSandwich, position, Quaternion.identity);
        nbSandwichsRestants++;
    }
}
