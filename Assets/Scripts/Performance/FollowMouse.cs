using UnityEngine;
using UnityEngine.InputSystem;

public class FollowMouse : MonoBehaviour
{
    private Vector2 _mousePosition;
    private InputManager _inputSystem;

    private void Start()
    {
        _inputSystem = GetComponent<InputManager>();
        _mousePosition = _inputSystem.MousePosition;
    }

    private void Update()
    {
        var zRotation = Mathf.Atan2(_mousePosition.y, _mousePosition.x) *  Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, zRotation);
    }
}
