using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Des m�thodes ont �t� introduites
 */
public class Poulet : MonoBehaviour
{
    [SerializeField] private float vitesseMarcher = 1.2f;
    [SerializeField] private float vitesseTourner = 150f;

    private Animator animateur;
    private AudioSource sonCoq;

    void Start()
    {
        animateur = GetComponent<Animator>();
        sonCoq = GameObject.Find("Cocorico").GetComponent<AudioSource>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");  // tourner � gauche ou � droite
        float vertical = Input.GetAxis("Vertical");      // avancer ou reculer

        BougerPoulet(horizontal, vertical);
        DeterminerAnimation(horizontal, vertical);
        
        // Cocorico
        if (Input.GetKeyDown(KeyCode.K))
        {
            sonCoq.Play();
        }
    }

    private void BougerPoulet(float horizontal, float vertical)
    {
        // D�place le poulet vers l'avant ou vers l'arri�re
        transform.Translate(Vector3.forward * vertical * vitesseMarcher * Time.deltaTime);

        // Fait tourner le poulet sur la gauche ou sur la droite
        transform.Rotate(Vector3.up, horizontal * vitesseTourner * Time.deltaTime);
    }

    private void DeterminerAnimation(float horizontal, float vertical)
    {
        // Fait marcher le poulet s'il se d�place
        bool entreeAxeHorizontal = !Mathf.Approximately(horizontal, 0f);
        bool entreeAxeVertical = !Mathf.Approximately(vertical, 0f);

        bool enMouvement = entreeAxeHorizontal || entreeAxeVertical;
        if (enMouvement)
        {
            animateur.SetBool("Walk", true);
        }
        else
        {
            animateur.SetBool("Walk", false);
        }

        // Fait picorer le poulet si la barre d'espacement est appuy�e
        if (Input.GetKey(KeyCode.Space))
        {
            animateur.SetBool("Eat", true);
        }
        else
        {
            animateur.SetBool("Eat", false);
        }
    }

}
