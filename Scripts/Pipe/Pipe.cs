using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float _speed;
    void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }
}
