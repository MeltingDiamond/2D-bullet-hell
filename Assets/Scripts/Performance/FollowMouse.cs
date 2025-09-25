using UnityEngine;
using UnityEngine.InputSystem;

public class FollowMouse : MonoBehaviour
{
    private Vector2 _mousePosition;
    private InputManager _inputSystem;

    private void Start()
    {
        _inputSystem = GetComponent<InputManager>();
    }
}
