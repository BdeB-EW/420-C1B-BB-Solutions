using UnityEngine;

public class CameraSurveillance : MonoBehaviour
{
    [SerializeField] private GameObject[] _positionsCamera;
    [SerializeField] private GameObject _camera;
    
    private int _index;
    private float _tempsAvantChangement;
    private float _tempsAccumule;

    // Start is called before the first frame update
    void Start()
    {
        _index = 0;
        _camera.transform.position = _positionsCamera[_index].transform.position;
        _camera.transform.LookAt(Vector3.zero);
        _tempsAvantChangement = 5.0f;
        _tempsAccumule = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        _tempsAccumule += Time.deltaTime;
        if (_tempsAccumule >= _tempsAvantChangement)
        {
            _tempsAccumule = 0.0f;
            _index = (_index + 1) % _positionsCamera.Length;
            _camera.transform.position = _positionsCamera[_index].transform.position;
            _camera.transform.LookAt(Vector3.zero);
        }
    }
}
