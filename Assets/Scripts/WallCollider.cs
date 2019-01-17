using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollider : MonoBehaviour {
    [SerializeField]
    private GameObject _player;
    private Movement _movement;
	// Use this for initialization
	void Start () {
        _movement = _player.gameObject.GetComponent<Movement>();
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player")&&_player)
        {
            _movement.Die();
        }
    }
}
