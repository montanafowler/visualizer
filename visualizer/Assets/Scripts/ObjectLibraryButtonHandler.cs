using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLibraryButtonHandler : MonoBehaviour
{
	private Cube cube;
	private Cone cone;
	private Sphere sphere;

    void enableCube() {
    	cube.enabled = true;
    	cone.enabled = false;
    	sphere.enabled = false;
    }

    void enableCone() {
    	cube.enabled = false;
    	cone.enabled = true;
    	sphere.enabled = false;
    }

    void enableSphere() {
    	cube.enabled = false;
    	cone.enabled = false;
    	sphere.enabled = true;
    }
}
