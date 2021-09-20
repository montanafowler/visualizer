using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertiesMenuButtonHandler : MonoBehaviour
{
	private Dictionary<string, GameObject> optionsSets = new Dictionary<string, GameObject>();

    void Start()
    {
        optionsSets["SCALE-ROTATE"] = GameObject.Find("ScaleRotateOptions");
		optionsSets["MATERIALS"] = GameObject.Find("MaterialsOptions");
		optionsSets["CAMERA"] = GameObject.Find("CameraOptions");
		optionsSets["LIGHTING"] = GameObject.Find("LightingOptions");
		enableOptions("SCALE-ROTATE");
    }

    public void enableOptions(string optionsType) 
    {
    	foreach(KeyValuePair<string, GameObject> optionsSet in optionsSets)
		{
		    if(optionsSet.Key == optionsType)
		    	optionsSet.Value.SetActive(true);
		    else
		    	optionsSet.Value.SetActive(false);
		}
    }
}
