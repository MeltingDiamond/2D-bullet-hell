using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private InputManager _input;
    private Rigidbody2D _rigidbody2D;

    public float moveSpeed;

    private void Start()
    {
        _input = GetComponent<InputManager>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (_input.Attack)
        {
            print("Player used Splash, but nothing happened!");
        }
    }

    private void FixedUpdate()
    {
        _rigidbody2D.linearVelocityX = _input.Horizontal *  moveSpeed;
        _rigidbody2D.linearVelocityY = _input.Vertical *  moveSpeed;
    }
}
