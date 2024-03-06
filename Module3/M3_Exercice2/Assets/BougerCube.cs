using UnityEngine;
using TMPro;

public class BougerCube : MonoBehaviour
{
    public TMP_InputField saisieX;
    public TMP_InputField saisieY;
    public TMP_InputField saisieZ;

    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DeplacerCube()
    {
        float x;
        float y;
        float z;

        if (float.TryParse(saisieX.text, out x) &&  float.TryParse(saisieY.text, out y) &&
            float.TryParse(saisieZ.text, out z))
        {
            cube.transform.position += new Vector3(x, y, z);
        }
    }

    public void TeleporterCube()
    {
        float x;
        float y;
        float z;

        if (float.TryParse(saisieX.text, out x) && float.TryParse(saisieY.text, out y) &&
            float.TryParse(saisieZ.text, out z))
        {
            cube.transform.position = new Vector3(x, y, z);
        }
    }
}
