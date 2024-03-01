using UnityEngine;
using TMPro;

public class AfficherPosition : MonoBehaviour
{
    public GameObject joueur;
    public TMP_Text valeurZ;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float z = joueur.transform.position.z;
        valeurZ.text = z.ToString("F2");
    }
}
