using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapher : MonoBehaviour {

	float z = 0; //input
	float x = 0; //real component of z
	float y = 0; //imaginary component of z

	float w = 0; //output
	float u = 0; //real component of w
	float v = 0; //imaginary component of w

	public GameObject Cube;

	float df = 0; //final distance (polar codinates) hypoynus of imaginary and real
	float tef = 0; //final angle made by line that goes through origin and complex number

	// Use this for initialization
	void Start ()
	{
		/*for(float cp = -10; cp <= 10; cp = cp + 0.2f){
			x = cp;
			u = cp*cp;
			Debug.Log(cp);
			Debug.Log(x);
			Debug.Log(u);
			Instantiate (Cube, new Vector3 (x, u, 0), Quaternion.identity);
		}*/

		//z is the input

		//w = f(z) = z^2
		for (float cp = -5; cp <= 5; cp = cp + 0.5f) {
			for (float cpi = -5; cpi <= 5; cpi = cpi + 0.5f) {
				x = cp;
				y = cpi;
				df = x*x + y*y; //skipped writing original d because that is just square root of df in this case cuz it is function x^2
				tef = 2 * Mathf.Atan((y/x));
				u = Mathf.Cos(tef) * df;
				v = Mathf.Sin(tef) * df;
				/*Debug.Log("START");
				Debug.Log(cp);
				Debug.Log(x);
				Debug.Log(y);
				Debug.Log(u);
				Debug.Log(v);*/
				Instantiate (Cube, new Vector3 (x, y, u), Quaternion.identity);
			}
		}


		//w = f(z) = z^2 + 1
		/*for (float cp = -5; cp <= 5; cp = cp + 0.5f) {
			for (float cpi = -5; cpi <= 5; cpi = cpi + 0.5f) {
				x = cp;
				y = cpi;
				df = x*x + y*y; //skipped writing original d because that is just square root of df in this case cuz it is function x^2
				tef = 2 * Mathf.Atan((y/x));
				u = Mathf.Cos(tef) * df + 1;
				v = Mathf.Sin(tef) * df;
				Instantiate (Cube, new Vector3 (x, y, u), Quaternion.identity);
			}
		}*/
	}
}
