using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class ButtonHandler : MonoBehaviour
{
    private Button _self;
    private void Awake()
    {
        _self = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _self.onClick.AddListener(OnButtonClick);
    }
    private void OnDisable()
    {
        _self.onClick.RemoveListener(OnButtonClick);
    }
    protected abstract void OnButtonClick();
}
