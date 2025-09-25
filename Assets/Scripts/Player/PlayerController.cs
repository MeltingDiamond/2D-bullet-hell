using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private InputManager _input;
    private Rigidbody2D _rigidbody2D;

    public float moveSpeed;
    
    public int maxHealth;
    public int currentHealth;

    private void Start()
    {
        _input = GetComponent<InputManager>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        
        currentHealth = maxHealth;
    }

    private void FixedUpdate()
    {
        _rigidbody2D.linearVelocityX = _input.Horizontal *  moveSpeed;
        _rigidbody2D.linearVelocityY = _input.Vertical *  moveSpeed;
    }

    public void TakeDamage(int amount)
    {
        if (currentHealth > 0)
        {
            currentHealth -= amount;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
