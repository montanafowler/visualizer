using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectLibraryButtonHandler : MonoBehaviour
{
	private Dictionary<string, GameObject> shapes = new Dictionary<string, GameObject>();

	void Start() 
	{
		// save references to the basic primitives
		shapes["CUBE"] = GameObject.Find("CubeObject");
		shapes["CYLINDER"] = GameObject.Find("CylinderObject");
		shapes["SPHERE"] = GameObject.Find("SphereObject");

		activateShape("CUBE"); // activate the cube first
	}

	/** activate the shape type */
	public void activateShape(string shapeType)
	{
		foreach(KeyValuePair<string, GameObject> shape in shapes)
		{
		    if(shape.Key == shapeType)
		    	shape.Value.SetActive(true);
		    else
		    	shape.Value.SetActive(false);
		}
	}
}
