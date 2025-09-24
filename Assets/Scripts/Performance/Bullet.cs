using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float killTimer = 10f; // initial time in seconds
    public float killTimerReset;
    public bool isAlive = true;


    private void Start()
    {
        isAlive = true;
        killTimerReset = killTimer;
    }
    
    private void Update()
    {
        if (isAlive)
        {
            if (killTimer > 0)
            {
                killTimer -= Time.deltaTime;
            }
            else
            {
                killTimer = 0f;
                gameObject.SetActive(false);
                isAlive = false;
            }
        }
        else
        {
            killTimer = killTimerReset;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            gameObject.SetActive(false);
        }
    }
}
