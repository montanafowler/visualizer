using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material diffuseMaterial;
    public Material metallicMaterial;
    public Material carpetMaterial;
    public Material woodMaterial;
    public Material dotsMaterial;
    public Material stoneMaterial;
    public Material checkersMaterial;
    
    /** get the active game object to change its material */
	private GameObject getActiveGameObject() 
	{
		GameObject cube = GameObject.Find("CubeObject");
    	GameObject sphere = GameObject.Find("SphereObject");
    	GameObject cylinder = GameObject.Find("CylinderObject");

    	if(cube)
    		return cube;
    	if(sphere)
    		return sphere;
    	if(cylinder)
    		return cylinder;
    	return null;
	}


    /** make the active game object diffuse */
    public void makeDiffuse() 
    {
    	getActiveGameObject().GetComponent<Renderer>().material = diffuseMaterial;
    }

    /** make the active game object metallic */
    public void makeMetallic() 
    {
    	getActiveGameObject().GetComponent<Renderer>().material = metallicMaterial;
    }

    /** make the active game object carpet */
    public void makeCarpet() 
    {
    	getActiveGameObject().GetComponent<Renderer>().material = carpetMaterial;
    }

    /** make the active game object wood */
    public void makeWood() 
    {
    	getActiveGameObject().GetComponent<Renderer>().material = woodMaterial;
    }

    /** make the active game object dots */
    public void makeDots() 
    {
    	getActiveGameObject().GetComponent<Renderer>().material = dotsMaterial;
    }

    /** make the active game object stone */
    public void makeStone() 
    {
    	getActiveGameObject().GetComponent<Renderer>().material = stoneMaterial;
    }

    /** make the active game object checkers */
    public void makeCheckers() 
    {
    	getActiveGameObject().GetComponent<Renderer>().material = checkersMaterial;
    }

}
