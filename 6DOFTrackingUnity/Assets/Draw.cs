using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour {

    public Transform cameraTransform;
    public bool mouseDown = false;
    GameObject myLine;
    public Material material;
    int index;
    LineRenderer lr;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(mouseDown)
        {
            DrawLine();
        }
	}

    void DrawLine()
    {
        lr.positionCount++;
        lr.SetPosition(index, cameraTransform.position);
        index++;
    }
    public void OnPointerDown()
    {
        mouseDown = true;
        myLine = new GameObject();
        myLine.transform.position = cameraTransform.position;
        myLine.AddComponent<LineRenderer>();
        lr = myLine.GetComponent<LineRenderer>();
        lr.material = material;
        lr.SetWidth(0.01f, 0.01f);
        lr.positionCount = 0;
        index = 0;
    }

    public void OnPointerUp()
    {
        mouseDown = false;
    }
}
