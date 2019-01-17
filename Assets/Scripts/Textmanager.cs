using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textmanager : MonoBehaviour {
    [SerializeField]
    private Text _text;
    [SerializeField]
    private GameObject _player;
    private Movement _movement;
	// Use this for initialization
	void Start () {
        _movement = _player.gameObject.GetComponent<Movement>();
	}
	
	// Update is called once per frame
	void Update () {
        if(_player)
        _text.text = "Punkte :  " + _movement.GetPunkte() ;	
	}
}
