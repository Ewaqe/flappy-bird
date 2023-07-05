using UnityEngine.SceneManagement;

public class MenuButtonHandler : ButtonHandler
{
    protected override void OnButtonClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
