using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class Parallax : MonoBehaviour
{
    [SerializeField] private float _speed;
    private RawImage _background;
    private float _backgroundPositionX = 0;

    private void Start()
    {
        _background = GetComponent<RawImage>();
    }

    private void Update()
    {
        _backgroundPositionX += _speed*Time.deltaTime;

        if (_backgroundPositionX > 1)
            _backgroundPositionX = 0;
        _background.uvRect = new Rect(_backgroundPositionX, _background.transform.position.y, _background.uvRect.width, _background.uvRect.height);
    }
}
