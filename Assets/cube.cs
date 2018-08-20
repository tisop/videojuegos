using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {
    public float velocidadMovimiento;
	// Use this for initialization
	void Start () {
        velocidadMovimiento = 3f;
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.Translate(Input.GetAxis("Horizontal") * velocidadMovimiento * Time.deltaTime, 0f, Input.GetAxis("Vertical") * velocidadMovimiento * Time.deltaTime);

    }
}
