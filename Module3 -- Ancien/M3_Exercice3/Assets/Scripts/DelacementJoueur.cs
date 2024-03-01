using UnityEngine;

public class DelacementJoueur : MonoBehaviour
{
    public GameObject plancher;
    public float vitesse;

    private Vector3 direction;
    private float limite;

    // Start is called before the first frame update
    void Start()
    {
        limite = plancher.transform.localScale.z * 5 - transform.localScale.z / 2;
        direction = new Vector3(0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * vitesse * Time.deltaTime;

        if (transform.position.z >= limite || transform.position.z <= -limite)
        {
            direction = -direction;
        }
    }
}
