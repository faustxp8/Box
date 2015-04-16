using UnityEngine;
using System.Collections;

public class Position : MonoBehaviour {
	void Start()
	{
		Vector3 pos = transform.position;
		pos.y =-2;
		transform.position = pos;
	}
	
	void Update () {
		
		Vector3 pos = transform.position;
		pos.y = GameObject.FindObjectOfType< CameraMover > ().pozitia - 3;
		transform.position = pos;
	}
}
