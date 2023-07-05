using UnityEngine;

public class ExitButtonHandler : ButtonHandler
{
    protected override void OnButtonClick()
    {
        Application.Quit();
    }
}
