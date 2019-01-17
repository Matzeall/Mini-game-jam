using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour {
    [SerializeField]
    private GameObject _object;
    private float _x;
    private float _y;
    

	public void CreateRandomFood()
    {
        Instantiate(_object,new Vector3(Random.Range(-6,6),Random.Range(-4,4),0),_object.transform.rotation);
    }
}
