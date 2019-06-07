using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour {
	public GameObject cube;

	float ex = 1;
	float ey = 1;
	float ez = 1;
	float ew = 1;

	float x = 0;
	float y = 0;
	float z = 0;
	float w = 5;
	
	void Start () {
		z = w*(ez/ew);
    	y = z*(ey/ez);
    	x = y*(ex/ey);
		Instantiate(cube, new Vector3(x, y, z), Quaternion.identity);
	}
}
