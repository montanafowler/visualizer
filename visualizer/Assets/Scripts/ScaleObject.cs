using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleObject : MonoBehaviour
{

    /** on slider changed, scale the active 3d model */
    public void sliderChanged() 
    {
    	Slider xSlider = GameObject.Find("XScaleSlider").GetComponent<Slider>();
    	Slider ySlider = GameObject.Find("YScaleSlider").GetComponent<Slider>();
    	Slider zSlider = GameObject.Find("ZScaleSlider").GetComponent<Slider>();  

    	GameObject cube = GameObject.Find("CubeObject");
    	GameObject sphere = GameObject.Find("SphereObject");
    	GameObject cylinder = GameObject.Find("CylinderObject");
    	
    	// if the cube is active, scale it
    	if(cube)
    		cube.transform.localScale = new Vector3(xSlider.value, ySlider.value, zSlider.value);
    	
    	// if the sphere is active, scale it
    	if(sphere)
    		sphere.transform.localScale = new Vector3(xSlider.value, ySlider.value, zSlider.value);

    	// if the cylinder is active, scale it
    	if(cylinder)
    		cylinder.transform.localScale = new Vector3(xSlider.value, ySlider.value, zSlider.value);
    }

}
