using UnityEngine;
using TMPro;

public class DireBonjour : MonoBehaviour
{

    [SerializeField] private TMP_Text texteBonjour;

    // Start is called before the first frame update
    void Start()
    {
        texteBonjour.text = "Bonjour!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
