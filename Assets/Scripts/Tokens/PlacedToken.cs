﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlacedToken : MonoBehaviour, IPointerDownHandler
{

    public int id;
    [HideInInspector]
    public bool isPlaced = false;

	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
            CharacterSelector.PickupToken(this);
        else if (eventData.button == PointerEventData.InputButton.Right)
            CharacterSelector.ResetToken(id);
    }

    public void OnMouseDown()
    {
        if (isPlaced)
        {
            Invoke("Pickup", 0.0f);
            //isPlaced = false;
        }
    }
    public void OnMouseUp()
    {
        //isPlaced = true;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            CharacterSelector.ResetToken(id);
            isPlaced = false;
        }
    }

    void Pickup()
    {
        CharacterSelector.PickupToken(this);
    }
}
