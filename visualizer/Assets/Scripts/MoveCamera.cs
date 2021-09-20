using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private Camera camera;
    private Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("MainCamera").GetComponent<Camera>();
        originalPosition = camera.gameObject.transform.position;
    }

    public void moveCamera(string direction) 
    {
    	switch(direction)
    	{
    		case "LEFT":
    			if(camera.gameObject.transform.position.x > 0)
    				camera.gameObject.transform.Translate(new Vector3(-10.0f, 0.0f, 0.0f));
    			break;
    		case "RIGHT":
    			if(camera.gameObject.transform.position.x < 166*2)
    				camera.gameObject.transform.Translate(new Vector3(10.0f, 0.0f, 0.0f));
    			break;
    		case "UP":
    			if(camera.gameObject.transform.position.y < 391*1.7)
    				camera.gameObject.transform.Translate(new Vector3(0.0f, 10.0f, 0.0f));
    			break;
    		case "DOWN":
    			if(camera.gameObject.transform.position.y > 391*0.3)
    				camera.gameObject.transform.Translate(new Vector3(0.0f, -10.0f, 0.0f));
    			break;
    		case "CENTER":
    			camera.gameObject.transform.position = originalPosition;
    			break;
    	}
    }
}
