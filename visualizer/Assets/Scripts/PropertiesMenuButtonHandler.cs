using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertiesMenuButtonHandler : MonoBehaviour
{
    private GameObject scaleRotateOptions;
	private GameObject materialsOptions;
	private GameObject cameraOptions;
	private GameObject lightingOptions;

    // Start is called before the first frame update
    void Start()
    {
        scaleRotateOptions = GameObject.Find("ScaleRotateOptions");
		materialsOptions = GameObject.Find("MaterialsOptions");
		// lightingOptions = GameObject.Find("SphereObject");
		if(materialsOptions)
			materialsOptions.SetActive(false);
    }

    public void enableMaterialsOptions() {
    	scaleRotateOptions.SetActive(false);
    	materialsOptions.SetActive(true);
    }

    public void enableScaleRotateOptions() {
    	scaleRotateOptions.SetActive(true);
    	materialsOptions.SetActive(false);
    }
}
