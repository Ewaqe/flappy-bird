using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private float _speed = 0.01f;
    private Vector2 _startPosition;
    private float _offset = 3.38f;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        transform.position = new Vector2(transform.position.x-_speed*Time.deltaTime, transform.position.y);

        if(transform.position.x <= _startPosition.x-_offset)
        {
            transform.position = _startPosition;
        }
    }
}
