using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
public class Cube_Properties : MonoBehaviour {
    //
    public Cube thisCube = new Cube();
    //
    void Start () {
        thisCube.obj = this.gameObject;
        //this.GetComponent<Renderer>().material = Grid.instance.materials[Random.Range(0, 2)];
        //this.GetComponent<Renderer>().material.color = Grid.instance.colors[Random.Range(0, 4)];
        //this.GetComponent<Renderer>().material.color = new Color(UnityEngine.Random.Range(0.0f, 1.0f), UnityEngine.Random.Range(0.0f, 1.0f), UnityEngine.Random.Range(0.0f, 1.0f));
        this.GetComponent<Renderer>().material.color = thisCube.cubeColor;
        this.transform.parent = Grid.instance.gridParent.transform;
	}
	//
	void FixedUpdate () {
        //this.GetComponent<Renderer>().material.color = new Color(UnityEngine.Random.Range(0.0f, 1.0f), UnityEngine.Random.Range(0.0f, 1.0f), UnityEngine.Random.Range(0.0f, 1.0f));
    }
}
