using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScrollWhileHover : MonoBehaviour {

    public float scrollSpeed;
    public Scrollbar scrollbar;

    Vector3 lowPoint;
    Vector3 highPoint;

    // Use this for initialization
    void Start ()
    {
        lowPoint = transform.position;
        highPoint = lowPoint + Vector3.up * 700;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetAxis("Mouse ScrollWheel") == 0)
            return;

        Vector3 pos = transform.position;
        transform.position -= Vector3.up * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed * Screen.height;
        if (transform.position.y < lowPoint.y)
            transform.position = new Vector3(pos.x, lowPoint.y, pos.z);
        if (transform.position.y > highPoint.y)
            transform.position = new Vector3(pos.x, highPoint.y, pos.z);

        if (Input.GetAxis("Mouse ScrollWheel") != 0)
            scrollbar.value = (transform.position.y - lowPoint.y) / (highPoint.y - lowPoint.y);
    }

    public void Scroll(float value)
    {
        transform.position = new Vector3(transform.position.x, lowPoint.y + scrollbar.value * (highPoint.y - lowPoint.y), 0);
    }
}
