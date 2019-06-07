using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
	public GameObject cube;

	float xa = 1;
	float ya = 1;
	float za = 1;
	float wa = 1;

	float xb = 0;
	float yb = 0;
	float zb = 1;
	float wb = 0;

	float x = 0;
	float y = 0;
	float z = 0;
	float w = 3;
	
	void Start () {
		if (za == zb) {
			z = za;
		} else {
			z = (w - (wa - (((wb - wa) / (zb - za)) * za))) / ((wb - wa) / (zb - za));
		}
		if (ya == yb) {
			y = ya;
		} else {
			y = (w - (wa - (((wb - wa) / (yb - ya)) * ya))) / ((wb - wa) / (yb - ya));
		}
		if (xa == xb) {
			x = xa;
		} else {
			x = (w - (wa - (((wb - wa) / (xb - xa)) * xa))) / ((wb - wa) / (xb - xa));
		}
	
		if (((x <= xb && x >= xa) || (x >= xb && x <= xa)) && ((y <= yb && y >= ya) || (y >= yb && y <= ya)) && ((z <= zb && z >= za) || (z >= zb && z <= za))) {
			Instantiate (cube, new Vector3 (x, y, z), Quaternion.identity);
		}
	}
}
