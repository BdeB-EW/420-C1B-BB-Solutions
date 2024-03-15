using UnityEngine;
using TMPro;

public class MouvementJoueur : MonoBehaviour
{
    public GameObject _plancher;
    public float _vitesseDeplacement;
    public TMP_Text _txtTemps;

    private float _tempsJeu;
    private float _limiteX;
    private float _limiteZ;

    // Start is called before the first frame update
    void Start()
    {
        _limiteX = _plancher.transform.localScale.x * 5 - transform.localScale.x / 2;
        _limiteZ = _plancher.transform.localScale.z * 5 - transform.localScale.z / 2;
    }

    // Update is called once per frame
    void Update()
    {
        // Affichage du temps de jeu
        _tempsJeu += Time.deltaTime;

        int nombreSecondes = (int)_tempsJeu;
        int minutes = nombreSecondes / 60;
        int secondes = nombreSecondes % 60;

        _txtTemps.text = minutes.ToString("00") + ":" + secondes.ToString("00");

        // Saisie des touches
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        // Déplacement du joueur
        Vector3 deplacement = new Vector3(horizontal, 0, vertical) * _vitesseDeplacement * Time.deltaTime;
        Vector3 nouvellePosition = transform.position + deplacement;

        // Avant de bouger, on vérifie si la nouvelle position est dans les limites du plancher
        if (nouvellePosition.x <= _limiteX && nouvellePosition.x >= -_limiteX &&
            nouvellePosition.z <= _limiteZ && nouvellePosition.z >= -_limiteZ)
        {
            transform.position = nouvellePosition;
        }
    }
}
