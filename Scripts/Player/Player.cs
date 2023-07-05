using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(AudioSource))]
public class Player : MonoBehaviour
{
    [SerializeField] private AudioClip _dieSound;
    [SerializeField] private AudioClip _pointSound;
    private int _score;
    private AudioSource _audio;

    public event UnityAction<int> Died;
    public event UnityAction<int> ScoreChanged;

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<ScoreZone>(out _))
            IncreaseScore();

        else 
            Die();
    }
    private void IncreaseScore()
    {
        _score++;
        _audio.PlayOneShot(_pointSound);
        ScoreChanged?.Invoke(_score);
    }
    private void Die()
    {
        _audio.PlayOneShot(_dieSound);
        Died?.Invoke(_score);
    }
}
