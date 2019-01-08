using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScrollWhileHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    bool hover;
    public float scrollSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position -= Vector3.up * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed * Screen.height;
	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        hover = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hover = false;
    }
}
