using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private int _poolSize;
    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject _poolContainer;

    private List<GameObject> _pool = new List<GameObject>();

    protected void Initialize()
    {
        for (int i = 0; i < _poolSize; i++)
        {
            GameObject target = Instantiate(_template, _poolContainer.transform);
            target.SetActive(false);
            _pool.Add(target);
        }
    }

    protected void DisableObjectsOutsideScreen()
    {
        Vector2 borderPoint = _camera.ViewportToWorldPoint(Vector2.zero);
        foreach (var children in _pool)
        {
            if (children.transform.position.x < borderPoint.x)
                children.SetActive(false);
        }
    }

    protected bool TryGetObject(out GameObject children)
    {
        children = _pool.FirstOrDefault(children => children.activeSelf == false);
        return children != null;
    }
}
