using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;
    private Movement _movement;
    private Create _create;

     void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _movement = _player.gameObject.GetComponent<Movement>();
        _create = _player.gameObject.GetComponent<Create>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_movement)
        {
            _create.CreateRandomFood();
            _movement.IncreaseSpeed();
            Destroy(gameObject);
            Debug.Log("Hit");
        }
    }
}
