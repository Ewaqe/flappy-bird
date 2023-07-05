using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Player _player;
    private TMP_Text _score;
    
    private void Start()
    {
        _score = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        _player.ScoreChanged += OnScoreChanged;
    }
    private void OnDisable()
    {
        _player.ScoreChanged -= OnScoreChanged;
    }

    private void OnScoreChanged(int score)
    {
        _score.text = score.ToString();
    }
}
