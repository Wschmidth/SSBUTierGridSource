using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour {

    public GameObject blankTokenPrefab;
    static PlacedToken heldToken;

    static GameObject blankToken;

    public static bool holdingToken { get; private set; }

    static bool snapping = true;
    public float gridSize;
    Camera cam;
    static float scale = 0.35f;

    static List<PlacedToken> tokens = new List<PlacedToken>();

	// Use this for initialization
	void Start ()
    {
        blankToken = blankTokenPrefab;
        cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.S))
            snapping = !snapping;

        holdingToken = heldToken != null;
		if (holdingToken)
        {
            heldToken.transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
            heldToken.transform.position += Vector3.back * cam.transform.position.z;
            if (snapping)
            {
                Vector3 pos = heldToken.transform.position + Vector3.zero;
                heldToken.transform.position = new Vector3(Mathf.RoundToInt(pos.x / gridSize) * gridSize, Mathf.RoundToInt(pos.y / gridSize) * gridSize, 0);
            }
            if (Input.GetMouseButtonUp(0))
            {
                heldToken.isPlaced = true;
                heldToken = null;
                holdingToken = false;
            }
            if (Input.GetMouseButtonDown(1))
            {
                ResetToken(heldToken.id);
                //Destroy(heldToken.gameObject);
            }
        }
        
	}

    public static void SelectCharacter(MenuToken character)
    {
        if (!holdingToken && !character.inPlace)
        {
            heldToken = Instantiate(blankToken).GetComponent<PlacedToken>();
            heldToken.GetComponent<SpriteRenderer>().sprite = character.GetComponent<Image>().sprite;
            heldToken.transform.position = Vector3.left * 100;
            heldToken.transform.localScale = Vector3.one * scale;
            heldToken.id = character.id;
            tokens.Add(heldToken);

            character.inPlace = true;
        }
    }

    public static PlacedToken FindToken(int id)
    {
        foreach (PlacedToken t in tokens)
        {
            if (t.id == id)
                return t;
        }

        return null;
    }

    public static void ResetToken(int id)
    {
        TokenManager.FindToken(id).inPlace = false;
        PlacedToken token = FindToken(id);
        tokens.Remove(token);
        Destroy(token.gameObject);
    }

    public static void PickupToken (PlacedToken token)
    {
        heldToken = token;
    }

    public void Resize(float value)
    {
        scale = 0.35f * (1 + value);
        foreach (PlacedToken token in tokens)
            token.transform.localScale = Vector3.one * scale;
    }
}
