using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("MainCamera").GetComponent<Camera>();
        originalPosition = mainCamera.gameObject.transform.position;
    }

    public void moveCamera(string direction) 
    {
    	switch(direction)
    	{
    		case "LEFT":
    			if(mainCamera.gameObject.transform.position.x > 0)
    				mainCamera.gameObject.transform.Translate(new Vector3(-10.0f, 0.0f, 0.0f));
    			break;
    		case "RIGHT":
    			if(mainCamera.gameObject.transform.position.x < 166*2)
    				mainCamera.gameObject.transform.Translate(new Vector3(10.0f, 0.0f, 0.0f));
    			break;
    		case "UP":
    			if(mainCamera.gameObject.transform.position.y < 391*1.7)
    				mainCamera.gameObject.transform.Translate(new Vector3(0.0f, 10.0f, 0.0f));
    			break;
    		case "DOWN":
    			if(mainCamera.gameObject.transform.position.y > 391*0.3)
    				mainCamera.gameObject.transform.Translate(new Vector3(0.0f, -10.0f, 0.0f));
    			break;
    		case "CENTER":
    			mainCamera.gameObject.transform.position = originalPosition;
    			break;
    	}
    }
}
