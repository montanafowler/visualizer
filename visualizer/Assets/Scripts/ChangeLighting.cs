using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLighting : MonoBehaviour
{
	private Dictionary<string, GameObject> lights = new Dictionary<string, GameObject>();

    /** fill light dictionary */
    void Start()
    {	
        lights["LEFT"] = GameObject.Find("LeftLight");
        lights["RIGHT"] = GameObject.Find("RightLight");
        lights["PINK"] = GameObject.Find("PinkLight");
        lights["BLUE"] = GameObject.Find("BlueLight");
        lights["GREEN"] = GameObject.Find("GreenLight");
        lights["ORANGE"] = GameObject.Find("OrangeLight");

        changeLighting("LEFT");
    }

    /** change the lighting */
    public void changeLighting(string lightType) 
    {
    	foreach(KeyValuePair<string, GameObject> light in lights)
		{
		    if(light.Key == lightType)
		    	light.Value.SetActive(true);
		    else
		    	light.Value.SetActive(false);
		}
    }
}
