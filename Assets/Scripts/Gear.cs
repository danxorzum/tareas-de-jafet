using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Gear : MonoBehaviour {
	void Update () {
        gameObject.transform.Rotate(transform.forward *-30* Time.deltaTime);
	}
}
