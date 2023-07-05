using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLoop : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _score;
    [SerializeField] private GameObject _endScreenPanel;
    [SerializeField] private TMP_Text _totalScore;
    [SerializeField] private Button _retry;
    [SerializeField] private Button _menu;
    private void OnEnable()
    {
        _player.Died += OnPlayerDied;
        _retry.onClick.AddListener(OnRetryButtonClick);
        _menu.onClick.AddListener(OnMenuButtonClick);
    }
    private void OnDisable()
    {
        _player.Died -= OnPlayerDied;
        _retry.onClick.RemoveListener(OnRetryButtonClick);
        _menu.onClick.RemoveListener(OnMenuButtonClick);
    }

    private void OnPlayerDied(int score)
    {
        Time.timeScale = 0;
        _score.SetActive(false);
        _endScreenPanel.SetActive(true);
        _totalScore.text = $"Your score is {score}";
    }

    private void OnRetryButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void OnMenuButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
