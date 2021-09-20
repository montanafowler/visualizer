using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateObject : MonoBehaviour
{
    /** on slider changed, scale the active 3d model */
    public void sliderChanged() 
    {
    	Slider xSlider = GameObject.Find("XRotateSlider").GetComponent<Slider>();
    	Slider ySlider = GameObject.Find("YRotateSlider").GetComponent<Slider>();
    	Slider zSlider = GameObject.Find("ZRotateSlider").GetComponent<Slider>();  

    	GameObject cube = GameObject.Find("CubeObject");
    	GameObject sphere = GameObject.Find("SphereObject");
    	GameObject cylinder = GameObject.Find("CylinderObject");
    	
    	// if the cube is active, rotate it
    	if(cube)
    		cube.transform.rotation = Quaternion.Euler(xSlider.value, ySlider.value, zSlider.value);
    	
    	// if the sphere is active, rotate it
    	if(sphere)
    		sphere.transform.rotation = Quaternion.Euler(xSlider.value, ySlider.value, zSlider.value);

    	// if the cylinder is active, rotate it
    	if(cylinder)
    		cylinder.transform.rotation = Quaternion.Euler(xSlider.value, ySlider.value, zSlider.value);
    }
}
