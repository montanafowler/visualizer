using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertiesMenuButtonHandler : MonoBehaviour
{
    private GameObject scaleRotateOptions;
	private GameObject materialsOptions;
	private GameObject cameraOptions;
	private GameObject lightingOptions;

    void Start()
    {
        scaleRotateOptions = GameObject.Find("ScaleRotateOptions");
		materialsOptions = GameObject.Find("MaterialsOptions");
		cameraOptions = GameObject.Find("CameraOptions");
		lightingOptions = GameObject.Find("LightingOptions");
		if(materialsOptions)
			materialsOptions.SetActive(false);
		if(cameraOptions)
			cameraOptions.SetActive(false);
		if(lightingOptions)
			lightingOptions.SetActive(false);
    }

    /** show the materials options */
    public void enableMaterialsOptions() 
    {
    	scaleRotateOptions.SetActive(false);
    	materialsOptions.SetActive(true);
    	cameraOptions.SetActive(false);
    	lightingOptions.SetActive(false);
    }

    /** show the scale/rotate options */
    public void enableScaleRotateOptions() 
    {
    	scaleRotateOptions.SetActive(true);
    	materialsOptions.SetActive(false);
    	cameraOptions.SetActive(false);
    	lightingOptions.SetActive(false);
    }

    /** show the camera options */
    public void enableCameraOptions() 
    {
    	scaleRotateOptions.SetActive(false);
    	materialsOptions.SetActive(false);
    	cameraOptions.SetActive(true);
    	lightingOptions.SetActive(false);
    }

    /** show the lighting options */
    public void enableLightingOptions() 
    {
    	scaleRotateOptions.SetActive(false);
    	materialsOptions.SetActive(false);
    	cameraOptions.SetActive(false);
    	lightingOptions.SetActive(true);
    }
}
