using UnityEngine;
using UnityEngine.InputSystem;

public class FollowMouse : MonoBehaviour
{
    private InputManager _inputSystem;

    private void Start()
    {
        _inputSystem = GetComponent<InputManager>();
    }

    private void Update()
    {
        var zRotation = Mathf.Atan2(_inputSystem.MousePosition.y, _inputSystem.MousePosition.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, zRotation - 90f);
    }
}
