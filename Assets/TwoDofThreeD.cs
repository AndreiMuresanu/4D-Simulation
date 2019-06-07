using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDofThreeD : MonoBehaviour {
	public GameObject cubeab;
	public GameObject cubeac;
	public GameObject cubead;
	public GameObject cubebc;
	public GameObject cubebd;
	public GameObject cubecd;

	//Point a
	float xa = 0;
	float ya = 0;
	float za = 0;

	//Point b
	float xb = 2;
	float yb = 0;
	float zb = 0;

	//Point c
	float xc = 1;
	float yc = 2;
	float zc = 1;

	//Point d
	float xd = 1;
	float yd = 0;
	float zd = 2;


	float x = 0;
	float y = 0;
	float z = 1f;
	
	void Start ()
	{

		//Line ab
		if (za != zb) {
			if (ya == yb) {
				y = ya;
			} else {
				y = (z - (za - (((zb - za) / (yb - ya)) * ya))) / ((zb - za) / (yb - ya));
			}
			if (xa == xb) {
				x = xa;
			} else {
				x = (z - (za - (((zb - za) / (xb - xa)) * xa))) / ((zb - za) / (xb - xa));
			}
		
			if (((x <= xb && x >= xa) || (x >= xb && x <= xa)) && ((y <= yb && y >= ya) || (y >= yb && y <= ya)) && ((z <= zb && z >= za) || (z >= zb && z <= za))) {
				Instantiate (cubeab, new Vector3 (x, y, 0f), Quaternion.identity);
			}
		}


		//Line ac
		if (za != zc) {
			if (ya == yc) {
				y = ya;
			} else {
				y = (z - (za - (((zc - za) / (yc - ya)) * ya))) / ((zc - za) / (yc - ya));
			}

			if (xa == xc) {
				x = xa;
			} else {
				x = (z - (za - (((zc - za) / (xc - xa)) * xa))) / ((zc - za) / (xc - xa));
			}

			if (((x <= xc && x >= xa) || (x >= xc && x <= xa)) && ((y <= yc && y >= ya) || (y >= yc && y <= ya)) && ((z <= zc && z >= za) || (z >= zc && z <= za))) {
				Instantiate (cubeac, new Vector3 (x, y, 0f), Quaternion.identity);
			}
		}


		//Line ad
		if (za != zd) {
			if (ya == yd) {
				y = ya;
			} else {
				y = (z - (za - (((zd - za) / (yd - ya)) * ya))) / ((zd - za) / (yd - ya));
			}

			if (xa == xd) {
				x = xa;
			} else {
				x = (z - (za - (((zd - za) / (xd - xa)) * xa))) / ((zd - za) / (xd - xa));
			}

			if (((x <= xd && x >= xa) || (x >= xd && x <= xa)) && ((y <= yd && y >= ya) || (y >= yd && y <= ya)) && ((z <= zd && z >= za) || (z >= zd && z <= za))) {
				Instantiate (cubead, new Vector3 (x, y, 0f), Quaternion.identity);
			}
		}


		//Line bc
		if (zb != zc) {
			if (yb == yc) {
				y = yb;
			} else {
				y = (z - (zb - (((zc - zb) / (yc - yb)) * yb))) / ((zc - zb) / (yc - yb));
			}

			if (xb == xc) {
				x = xb;
			} else {
				x = (z - (zb - (((zc - zb) / (xc - xb)) * xb))) / ((zc - zb) / (xc - xb));
			}

			if (((x <= xc && x >= xb) || (x >= xc && x <= xb)) && ((y <= yc && y >= yb) || (y >= yc && y <= yb)) && ((z <= zc && z >= zb) || (z >= zc && z <= zb))) {
				Instantiate (cubebc, new Vector3 (x, y, 0f), Quaternion.identity);
			}
		}


		//Line bd
		if (zb != zd) {
			if (yb == yd) {
				y = yb;
			} else {
				y = (z - (zb - (((zd - zb) / (yd - yb)) * yb))) / ((zd - zb) / (yd - yb));
			}

			if (xb == xd) {
				x = xb;
			} else {
				x = (z - (zb - (((zd - zb) / (xd - xb)) * xb))) / ((zd - zb) / (xd - xb));
			}

			if (((x <= xd && x >= xb) || (x >= xd && x <= xb)) && ((y <= yd && y >= yb) || (y >= yd && y <= yb)) && ((z <= zd && z >= zb) || (z >= zd && z <= zb))) {
				Instantiate (cubebd, new Vector3 (x, y, 0f), Quaternion.identity);
			}
		}


		//Line cd
		if (zb != zd) {
			if (yc == yd) {
				y = yc;
			} else {
				y = (z - (zc - (((zd - zc) / (yd - yc)) * yc))) / ((zd - zc) / (yd - yc));
			}

			if (xc == xd) {
				x = xc;
			} else {
				x = (z - (zc - (((zd - zc) / (xd - xc)) * xc))) / ((zd - zc) / (xd - xc));
			}

			if (((x <= xd && x >= xc) || (x >= xd && x <= xc)) && ((y <= yd && y >= yc) || (y >= yd && y <= yc)) && ((z <= zd && z >= zc) || (z >= zd && z <= zc))) {
				Instantiate (cubecd, new Vector3 (x, y, 0f), Quaternion.identity);
			}
		}
	}
}
