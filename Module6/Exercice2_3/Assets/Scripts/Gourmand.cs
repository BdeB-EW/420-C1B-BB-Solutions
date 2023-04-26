using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Gourmand : MonoBehaviour
{
    private GestionnaireJeu gestionnaireJeu;
    private GameObject sandwich;

    private NavMeshAgent agentIA;
    private Animator animateur;
    //private AudioSource sonSandwich;

    private float tempsAttente = 1;
    private float tempsAttendu = 0;

    private bool enMouvement = false;

    void Start()
    {
        agentIA = GetComponent<NavMeshAgent>();
        animateur = GetComponent<Animator>();

        //sonSandwich = GameObject.Find("Crounch").GetComponent<AudioSource>();
        gestionnaireJeu = GameObject.Find("GestionnaireJeu").GetComponent<GestionnaireJeu>();
    }

    
    void Update()
    {
        tempsAttendu += Time.deltaTime;
        if (tempsAttendu >= tempsAttente)
        {
            tempsAttendu = tempsAttente;
            if (!agentIA.pathPending && (agentIA.remainingDistance <= agentIA.stoppingDistance))
            {
                DirigerVersUnSandwich();
            }

            animateur.SetBool("marcher", enMouvement);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sandwich")
        {
            gestionnaireJeu.MangerSandwich(other.gameObject);
            DirigerVersUnSandwich();
        }
    }

    private void DirigerVersUnSandwich()
    {
        enMouvement = false;

        sandwich = GameObject.FindGameObjectWithTag("Sandwich");
        if (sandwich != null)
        {
            // On crée un nouveau vecteur de destination à partir de la position du sandwich
            // (pour garder la destination en mémoire même si l'objet de jeu du sandwich est détruit)
            Vector3 position = sandwich.transform.position;
            Vector3 destination = new Vector3(position.x, position.y, position.z);

            agentIA.SetDestination(destination);

            enMouvement = true;
        }
    }
}
