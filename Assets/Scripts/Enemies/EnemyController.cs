using System;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private Transform _target;
    private Vector2 _moveDirection;
    
    public float moveSpeed;
    
    public int maxHealth;
    public int currentHealth;
    public int damage;
    public float knockbackForce;

    private void Start()
    {
        currentHealth = maxHealth;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (_target)
        {
            Vector3 direction = (_target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            _rigidbody2D.rotation = angle;
            _moveDirection = direction;
        }
    }

    private void FixedUpdate()
    {
        if (_target)
        {
            _rigidbody2D.linearVelocity = new Vector2(_moveDirection.x, _moveDirection.y) *  moveSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerController player = other.gameObject.GetComponent<PlayerController>();
            /*
            Rigidbody2D rigidPlayer = other.gameObject.GetComponent<Rigidbody2D>();
            Vector2 knockbackDirection = (transform.position - other.gameObject.transform.position).normalized;
            rigidPlayer.AddForce(knockbackDirection * knockbackForce, ForceMode2D.Impulse);
            */
            player.TakeDamage(damage);
        }
    }
}
