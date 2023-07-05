using UnityEngine.SceneManagement;

public class PlayButtonHandler : ButtonHandler
{
    protected override void OnButtonClick()
    {
        SceneManager.LoadScene("Game");
    }
}
