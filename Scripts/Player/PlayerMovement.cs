using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _maxRotation;
    [SerializeField] private float _minRotation;
    [SerializeField] private float _rotationSpeed;
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (transform.rotation.y != _minRotation)
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, _minRotation), _rotationSpeed * Time.deltaTime);
    }
    public void Jump()
    {
        _rigidbody2D.AddForce(Vector2.up * _jumpForce);
        _rigidbody2D.velocity = Vector2.zero;
        transform.rotation = Quaternion.Euler(0, 0, _maxRotation);
    }
}
