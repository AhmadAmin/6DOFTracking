using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
public class VuforiaCamera : MonoBehaviour {
    public GameObject BackgroundTexture;
    public Text text;
	// Use this for initialization
	void Start () {
        //Camera.main.clearFlags = CameraClearFlags.Skybox;


	}
	
	// Update is called once per frame
	void Update () {
        /*if(BackgroundTexture!=null && BackgroundTexture.activeInHierarchy)
        {
            BackgroundTexture.SetActive(false);
        }
        if(BackgroundTexture==null)
        {
            BackgroundTexture = GameObject.Find("BackgroundPlane");
        }*/

        if(text!=null)
            text.text = transform.position.ToString();
	}
}
