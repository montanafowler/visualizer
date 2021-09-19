using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectLibraryButtonHandler : MonoBehaviour
{
	private GameObject cube;
	private GameObject cylinder;
	private GameObject sphere;

	void Start() {
		// save references to the basic primitives
		cube = GameObject.Find("CubeObject");
		cylinder = GameObject.Find("CylinderObject");
		sphere = GameObject.Find("SphereObject");

		// deactivate the cylinder and sphere if they aren't already deactivated
		if(cylinder)
			cylinder.SetActive(false);
		if(sphere)
			sphere.SetActive(false);
	}

	/** enable the cube primitive */
    public void enableCube() {
    	cube.SetActive(true);
    	cylinder.SetActive(false);
    	sphere.SetActive(false);
    }

    /** enable the cylinder primitive */
    public void enableCylinder() {
    		cube.SetActive(false);
    		cylinder.SetActive(true);
    		sphere.SetActive(false);
    }

    /** enable the sphere primitive */
    public void enableSphere() {
    	cube.SetActive(false);
    	cylinder.SetActive(false);
    	sphere.SetActive(true);
    }
    
}
