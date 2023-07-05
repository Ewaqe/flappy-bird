using UnityEngine;

public class PipeGeneration : ObjectPool
{
    [SerializeField] float _maxGenerationHeight;
    [SerializeField] float _minGenerationHeight;
    [SerializeField] float _coolDown;

    private GameObject _currentObject;
    private float _elapsedTime = 0f;

    private void Start()
    {
        Initialize();
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if(_elapsedTime >= _coolDown)
        {
            _elapsedTime = 0;

            if(TryGetObject(out _currentObject))
            {
                _currentObject.SetActive(true);
                _currentObject.transform.position = new Vector2(transform.position.x, Random.Range(_minGenerationHeight, _maxGenerationHeight));
            }
            DisableObjectsOutsideScreen();
        }
    }
}
