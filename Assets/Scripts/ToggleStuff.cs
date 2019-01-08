using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleStuff : MonoBehaviour {

    public GameObject helpMenu;
    public GameObject grid;
    public GameObject characterMenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.H))
            helpMenu.SetActive(!helpMenu.activeSelf);

        if (Input.GetKeyDown(KeyCode.G))
            grid.SetActive(!grid.activeSelf);

        if (Input.GetKeyDown(KeyCode.C))
            characterMenu.SetActive(!characterMenu.activeSelf);
    }
}
