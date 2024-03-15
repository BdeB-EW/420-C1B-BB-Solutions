using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MouvementJoueur : MonoBehaviour
{
    public GameObject _plancher;
    public float _vitesseDeplacement;
    public float _vitesseRotation;
    public TMP_Text _txtTemps;
    public TMP_Text _txtNombre;
    public Button _btnRecommencer;

    private float _tempsJeu;
    private float _limiteX;
    private float _limiteZ;

    private int _nbObjectifs;

    // Start is called before the first frame update
    void Start()
    {
        _limiteX = _plancher.transform.localScale.x * 5 - transform.localScale.x / 2;
        _limiteZ = _plancher.transform.localScale.z * 5 - transform.localScale.z / 2;

        _nbObjectifs = GameObject.FindGameObjectsWithTag("Objectif").Length;
        _txtNombre.text = _nbObjectifs.ToString();
        _btnRecommencer.gameObject.SetActive(false);
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

        // Rotation du joueur
        float angle = horizontal * _vitesseRotation * Time.deltaTime;
        transform.Rotate(Vector3.up, angle);

        // Déplacement du joueur
        Vector3 deplacement = new Vector3(0, 0, vertical) * _vitesseDeplacement * Time.deltaTime;
        deplacement = transform.TransformDirection(deplacement);
            
        Vector3 nouvellePosition = transform.position + deplacement;

        // Avant de bouger, on vérifie si la nouvelle position est dans les limites du plancher
        if (nouvellePosition.x <= _limiteX && nouvellePosition.x >= -_limiteX &&
            nouvellePosition.z <= _limiteZ && nouvellePosition.z >= -_limiteZ)
        {
            transform.position = nouvellePosition;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Objectif")
        {
            _nbObjectifs--;
            _txtNombre.text = _nbObjectifs.ToString();
            if (_nbObjectifs == 0)
            {
                _btnRecommencer.gameObject.SetActive(true);
                Time.timeScale = 0.0f;
            }
        }
    }
}
