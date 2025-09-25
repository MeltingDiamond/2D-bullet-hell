using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform _player;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        transform.position = new Vector3(_player.position.x, _player.position.y, -10);
    }
    
}
