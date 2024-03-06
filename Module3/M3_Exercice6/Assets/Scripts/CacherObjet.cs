using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CacherObjet : MonoBehaviour
{
    [SerializeField] private GameObject[] objetsACacher;
    [SerializeField]  private float _delai = 1f;

    private float tempsAccumule;
    private int _indexCache;

    // Start is called before the first frame update
    void Start()
    {
        tempsAccumule = 0f;
        _indexCache = -1;   // -1 pour indiquer que rien n'est caché
    }

    // Update is called once per frame
    void Update()
    {
        tempsAccumule += Time.deltaTime;
        if (tempsAccumule >= _delai)
        {
            tempsAccumule = 0f;
            if (_indexCache >= 0)
            {
                objetsACacher[_indexCache].SetActive(true);
            }
            _indexCache = Random.Range(0, objetsACacher.Length);
            objetsACacher[_indexCache].SetActive(false);
        }
    }
}
