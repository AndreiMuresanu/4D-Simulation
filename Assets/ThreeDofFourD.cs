using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeDofFourD : MonoBehaviour {
	public GameObject cubeab;
	public GameObject cubeac;
	public GameObject cubead;
	public GameObject cubeae;
	public GameObject cubebc;
	public GameObject cubebd;
	public GameObject cubebe;
	public GameObject cubecd;
	public GameObject cubece;
	public GameObject cubede;

	//Point a
	float xa = 0;
	float ya = 2;
	float za = 0;
	float wa = 1;

	//Point b
	float xb = 3;
	float yb = 0;
	float zb = 4;
	float wb = 0;

	//Point c
	float xc = 1;
	float yc = 3;
	float zc = 3;
	float wc = 4;

	//Point d
	float xd = 4;
	float yd = 1;
	float zd = 1;
	float wd = 3;

	//Point e
	float xe = 2;
	float ye = 4;
	float ze = 2;
	float we = 2;

	float x = 0;
	float y = 0;
	float z = 0;
	float w = 2f;


	void Start ()
	{
		//Line ab
		if (wa != wb) {
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
		
			if (((x <= xb && x >= xa) || (x >= xb && x <= xa)) && ((y <= yb && y >= ya) || (y >= yb && y <= ya)) 
				&& ((z <= zb && z >= za) || (z >= zb && z <= za)) && ((w <= wb && w >= wa) || (w >= wb && w <= wa))) {
				Instantiate (cubeab, new Vector3 (x, y, z), Quaternion.identity);
			}
		}


		//Line ac
		if (wa != wc) {
			if (za == zc) {
				z = za;
			} else {
				z = (w - (wa - (((wc - wa) / (zc - za)) * za))) / ((wc - wa) / (zc - za));
			}
			if (ya == yc) {
				y = ya;
			} else {
				y = (w - (wa - (((wc - wa) / (yc - ya)) * ya))) / ((wc - wa) / (yc - ya));
			}
			if (xa == xc) {
				x = xa;
			} else {
				x = (w - (wa - (((wc - wa) / (xc - xa)) * xa))) / ((wc - wa) / (xc - xa));
			}
		
			if (((x <= xc && x >= xa) || (x >= xc && x <= xa)) && ((y <= yc && y >= ya) || (y >= yc && y <= ya)) 
				&& ((z <= zc && z >= za) || (z >= zc && z <= za)) && ((w <= wc && w >= wa) || (w >= wc && w <= wa))) {
				Instantiate (cubeac, new Vector3 (x, y, z), Quaternion.identity);
			}
		}


		//Line ad
		if (wa != wd) {
			if (za == zd) {
				z = za;
			} else {
				z = (w - (wa - (((wd - wa) / (zd - za)) * za))) / ((wd - wa) / (zd - za));
			}
			if (ya == yd) {
				y = ya;
			} else {
				y = (w - (wa - (((wd - wa) / (yd - ya)) * ya))) / ((wd - wa) / (yd - ya));
			}
			if (xa == xd) {
				x = xa;
			} else {
				x = (w - (wa - (((wd - wa) / (xd - xa)) * xa))) / ((wd - wa) / (xd - xa));
			}
		
			if (((x <= xd && x >= xa) || (x >= xd && x <= xa)) && ((y <= yd && y >= ya) || (y >= yd && y <= ya)) 
				&& ((z <= zd && z >= za) || (z >= zd && z <= za)) && ((w <= wd && w >= wa) || (w >= wd && w <= wa))) {
				Instantiate (cubead, new Vector3 (x, y, z), Quaternion.identity);
			}
		}


		//Line ae
		if (wa != we) {
			if (za == ze) {
				z = za;
			} else {
				z = (w - (wa - (((we - wa) / (ze - za)) * za))) / ((we - wa) / (ze - za));
			}
			if (ya == ye) {
				y = ya;
			} else {
				y = (w - (wa - (((we - wa) / (ye - ya)) * ya))) / ((we - wa) / (ye - ya));
			}
			if (xa == xe) {
				x = xa;
			} else {
				x = (w - (wa - (((we - wa) / (xe - xa)) * xa))) / ((we - wa) / (xe - xa));
			}
		
			if (((x <= xe && x >= xa) || (x >= xe && x <= xa)) && ((y <= ye && y >= ya) || (y >= ye && y <= ya)) 
				&& ((z <= ze && z >= za) || (z >= ze && z <= za)) && ((w <= we && w >= wa) || (w >= we && w <= wa))) {
				Instantiate (cubeae, new Vector3 (x, y, z), Quaternion.identity);
			}
		}


		//Line bc
		if (wb != wc) {
			if (zb == zc) {
				z = zb;
			} else {
				z = (w - (wb - (((wc - wb) / (zc - zb)) * zb))) / ((wc - wb) / (zc - zb));
			}
			if (yb == yc) {
				y = yb;
			} else {
				y = (w - (wb - (((wc - wb) / (yc - yb)) * yb))) / ((wc - wb) / (yc - yb));
			}
			if (xb == xc) {
				x = xb;
			} else {
				x = (w - (wb - (((wc - wb) / (xc - xb)) * xb))) / ((wc - wb) / (xc - xb));
			}
		
			if (((x <= xc && x >= xb) || (x >= xc && x <= xb)) && ((y <= yc && y >= yb) || (y >= yc && y <= yb)) 
				&& ((z <= zc && z >= zb) || (z >= zc && z <= zb)) && ((w <= wc && w >= wb) || (w >= wc && w <= wb))) {
				Instantiate (cubebc, new Vector3 (x, y, z), Quaternion.identity);
			}
		}


		//Line bd
		if (wb != wd) {
			if (zb == zd) {
				z = zb;
			} else {
				z = (w - (wb - (((wd - wb) / (zd - zb)) * zb))) / ((wd - wb) / (zd - zb));
			}
			if (yb == yd) {
				y = yb;
			} else {
				y = (w - (wb - (((wd - wb) / (yd - yb)) * yb))) / ((wd - wb) / (yd - yb));
			}
			if (xb == xd) {
				x = xb;
			} else {
				x = (w - (wb - (((wd - wb) / (xd - xb)) * xb))) / ((wd - wb) / (xd - xb));
			}
		
			if (((x <= xd && x >= xb) || (x >= xd && x <= xb)) && ((y <= yd && y >= yb) || (y >= yd && y <= yb)) 
				&& ((z <= zd && z >= zb) || (z >= zd && z <= zb)) && ((w <= wd && w >= wb) || (w >= wd && w <= wb))) {
				Instantiate (cubebd, new Vector3 (x, y, z), Quaternion.identity);
			}
		}


		//Line be
		if (wb != we) {
			if (zb == ze) {
				z = zb;
			} else {
				z = (w - (wb - (((we - wb) / (ze - zb)) * zb))) / ((we - wb) / (ze - zb));
			}
			if (yb == ye) {
				y = yb;
			} else {
				y = (w - (wb - (((we - wb) / (ye - yb)) * yb))) / ((we - wb) / (ye - yb));
			}
			if (xb == xe) {
				x = xb;
			} else {
				x = (w - (wb - (((we - wb) / (xe - xb)) * xb))) / ((we - wb) / (xe - xb));
			}
		
			if (((x <= xe && x >= xb) || (x >= xe && x <= xb)) && ((y <= ye && y >= yb) || (y >= ye && y <= yb)) 
				&& ((z <= ze && z >= zb) || (z >= ze && z <= zb)) && ((w <= we && w >= wb) || (w >= we && w <= wb))) {
				Instantiate (cubebe, new Vector3 (x, y, z), Quaternion.identity);
			}
		}


		//Line cd
		if (wc != wd) {
			if (zc == zd) {
				z = zc;
			} else {
				z = (w - (wc - (((wd - wc) / (zd - zc)) * zc))) / ((wd - wc) / (zd - zc));
			}
			if (yc == yd) {
				y = yc;
			} else {
				y = (w - (wc - (((wd - wc) / (yd - yc)) * yc))) / ((wd - wc) / (yd - yc));
			}
			if (xc == xd) {
				x = xc;
			} else {
				x = (w - (wc - (((wd - wc) / (xd - xc)) * xc))) / ((wd - wc) / (xd - xc));
			}
		
			if (((x <= xd && x >= xc) || (x >= xd && x <= xc)) && ((y <= yd && y >= yc) || (y >= yd && y <= yc)) 
				&& ((z <= zd && z >= zc) || (z >= zd && z <= zc)) && ((w <= wd && w >= wc) || (w >= wd && w <= wc))) {
				Instantiate (cubecd, new Vector3 (x, y, z), Quaternion.identity);
			}
		}


		//Line ce
		if (wc != we) {
			if (zc == ze) {
				z = zc;
			} else {
				z = (w - (wc - (((we - wc) / (ze - zc)) * zc))) / ((we - wc) / (ze - zc));
			}
			if (yc == ye) {
				y = yc;
			} else {
				y = (w - (wc - (((we - wc) / (ye - yc)) * yc))) / ((we - wc) / (ye - yc));
			}
			if (xc == xe) {
				x = xc;
			} else {
				x = (w - (wc - (((we - wc) / (xe - xc)) * xc))) / ((we - wc) / (xe - xc));
			}
		
			if (((x <= xe && x >= xc) || (x >= xe && x <= xc)) && ((y <= ye && y >= yc) || (y >= ye && y <= yc)) 
				&& ((z <= ze && z >= zc) || (z >= ze && z <= zc)) && ((w <= we && w >= wc) || (w >= we && w <= wc))) {
				Instantiate (cubece, new Vector3 (x, y, z), Quaternion.identity);
			}
		}


		//Line de
		if (wd != we) {
			if (zd == ze) {
				z = zd;
			} else {
				z = (w - (wd - (((we - wd) / (ze - zd)) * zd))) / ((we - wd) / (ze - zd));
			}
			if (yd == ye) {
				y = yd;
			} else {
				y = (w - (wd - (((we - wd) / (ye - yd)) * yd))) / ((we - wd) / (ye - yd));
			}
			if (xd == xe) {
				x = xd;
			} else {
				x = (w - (wd - (((we - wd) / (xe - xd)) * xd))) / ((we - wd) / (xe - xd));
			}
		
			if (((x <= xe && x >= xd) || (x >= xe && x <= xd)) && ((y <= ye && y >= yd) || (y >= ye && y <= yd)) 
				&& ((z <= ze && z >= zd) || (z >= ze && z <= zd)) && ((w <= we && w >= wd) || (w >= we && w <= wd))) {
				Instantiate (cubede, new Vector3 (x, y, z), Quaternion.identity);
			}
		}
	}
}
