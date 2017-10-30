using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMouse : MonoBehaviour {
    private Vector3 screenPoint;
    private Vector3 offset;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        this.screenPoint = Camera.main.WorldToScreenPoint(Input.mousePosition);
        this.offset = transform.position - Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
    }

    private void OnMouseDrag()
    {
        Vector3 curScreenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z);
        Vector3 curPos = Camera.main.ScreenToWorldPoint(curScreenPos) + offset;
        transform.position = curPos;
    }
}
