using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void DeleteBtn()
    {
        LineRenderer[] lines = FindObjectsOfType<LineRenderer>();
        for (int index = 0; index < lines.Length; index++)
        {
            Destroy(lines[index].gameObject);
        }
    }
}
