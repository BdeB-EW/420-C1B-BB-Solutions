using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        float horizontal = Input.GetAxis("Horizontal");  // tourner à gauche ou à droite
        float vertical = Input.GetAxis("Vertical");      // avancer ou reculer

        // Déplace le poulet vers l'avant ou vers l'arrière
        transform.Translate(Vector3.forward * vertical * vitesseMarcher * Time.deltaTime);

        // Fait tourner le poulet sur la gauche ou sur la droite
        transform.Rotate(Vector3.up, horizontal * vitesseTourner * Time.deltaTime);

        // Fait picorer le poulet si la barre d'espacement est appuyée
        if (Input.GetKey(KeyCode.Space))
        {
            animateur.SetBool("Eat", true);
        }
        else
        {
            animateur.SetBool("Eat", false);
        }

        // Fait marcher le poulet s'il se déplace
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

        // Cocorico
        if (Input.GetKeyDown(KeyCode.K))
        {
            sonCoq.Play();
        }
    }
}
