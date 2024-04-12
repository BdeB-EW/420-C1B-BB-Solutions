using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject _zoneNombrePoules;
    public GameObject _zoneReprendre;

    public TMP_Text _nombrePoules;
    public GameObject[] _pointsPoules;
    
    private int _poulesRestantes;

    // Start is called before the first frame update
    void Start()
    {
        // Pour quand on reprend
        Time.timeScale = 1;

        _zoneNombrePoules.SetActive(true);
        _zoneReprendre.SetActive(false);

        GameObject[] poules = GameObject.FindGameObjectsWithTag("Poule");
        _poulesRestantes = poules.Length;
        _nombrePoules.text = _poulesRestantes.ToString();

        // Donne une destination à chaque poule
        for (int i = 0; i < poules.Length; i++)
        {
            int indice = Random.Range(0, _pointsPoules.Length);
            poules[i].GetComponent<MouvementPoulet>().destination = _pointsPoules[indice].transform.position;
        }
    }

    public void PouleDevoree()
    {
        _poulesRestantes--;
        _nombrePoules.text = _poulesRestantes.ToString();

        if (_poulesRestantes == 0)
        {
            Time.timeScale = 0;
            _zoneReprendre.SetActive(true);
            _zoneNombrePoules.SetActive(false);
        }
        else
        {
            GameObject[] poules = GameObject.FindGameObjectsWithTag("Poule");
            for (int i = 0; i < poules.Length; i++)
            {
                int indice = Random.Range(0, _pointsPoules.Length);
                poules[i].GetComponent<MouvementPoulet>().destination = _pointsPoules[indice].transform.position;
            }
        }
    }

    public void Reprendre()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
