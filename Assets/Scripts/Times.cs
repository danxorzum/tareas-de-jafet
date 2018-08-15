using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Times : MonoBehaviour {
   public GameObject horas;
    public GameObject minutos;
    int h;

	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void Update() {
        h = Mathf.Abs(System.DateTime.Now.Hour - 12);
        
            horas.transform.rotation=Quaternion.Euler(new Vector3( 0f,0f, h*-30 +90 ));
            minutos.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, DateTime.Now.Minute*-6+90 ));
        Debug.Log(DateTime.Now.Minute);


    }
}
