using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuToken : MonoBehaviour, IPointerDownHandler
{
    public int id;
    public bool inPlace = false;

    Image img;

	// Use this for initialization
	void Start ()
    {
        img = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (inPlace)
            img.color = new Color(0.5f, 0.5f, 0.5f, 1);
        else
            img.color = Color.white;
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
            Invoke("Select", 0.1f);
        else if (eventData.button == PointerEventData.InputButton.Right)
            CharacterSelector.ResetToken(id);
    }

    void Select()
    {
        CharacterSelector.SelectCharacter(this);
    }
}
