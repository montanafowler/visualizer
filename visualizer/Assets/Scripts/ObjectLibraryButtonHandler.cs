using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLibraryButtonHandler : MonoBehaviour
{
	private GameObject cube;
	private GameObject cylinder;
	private GameObject sphere;

	void Start() {
		cube = GameObject.Find("CubeObject");//.GetComponent<MoveObject>();
		cylinder = GameObject.Find("CylinderObject");//.GetComponent<Cylinder>();
		sphere = GameObject.Find("SphereObject");//.GetComponent<Sphere>();
		cylinder.SetActive(false);
  //  	sphere.SetActive(false);
	}

    public void enableCube() {
    	cube.SetActive(true);
    	cylinder.SetActive(false);
    	sphere.SetActive(false);
    }

    public void enableCylinder() {
    	cube.SetActive(false);
    	cylinder.SetActive(true);
    	sphere.SetActive(false);
    }

    public void enableSphere() {
    	cube.SetActive(false);
    	cylinder.SetActive(false);
    	sphere.SetActive(true);
    }
    
}
