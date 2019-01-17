using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    private Vector2 _dir;
    [SerializeField]
    private float _rotSpeed;
    [SerializeField]
    private float _speed;
    private Rigidbody2D _rgbd;
    [SerializeField]
    private float _speedIncreaseValue;
    private int _punkte = 0;
   

    // Use this for initialization
    void Start () {
        _rgbd = GetComponent<Rigidbody2D>();
        _dir = transform.up;
	}
	
	// Update is called once per frame
	void Update () {
        _dir = transform.up;
        _rgbd.velocity = _dir.normalized * _speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, 1), -_rotSpeed* Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 1), _rotSpeed* Time.deltaTime);
        }
	}

    public void IncreaseSpeed()
    {
        _speed += _speedIncreaseValue;
        _rotSpeed += _speedIncreaseValue;
        _punkte += 100;
    }

    public int  GetPunkte()
    {
        return _punkte;
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
