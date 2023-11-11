using UnityEngine;
using UnityEngine.UI;

public class UISpaceShipInput : MonoBehaviour
{
    [SerializeField] private Joystick joystick;
    [SerializeField] private Button fireButton;

    public float Horizontal => joystick.Horizontal;
    public float Vertical => joystick.Vertical;
    public bool NeedFire => _needFireRequested;

    private bool _needFireRequested;

    private void OnEnable()
    {
        fireButton.onClick.AddListener(OnFire);
    }

    private void OnDisable()
    {
        fireButton.onClick.RemoveListener(OnFire);
    }

    private void OnFire()
    {
        _needFireRequested = true;
    }

    public void InputReaded()
    {
        _needFireRequested = false;
    }
}
