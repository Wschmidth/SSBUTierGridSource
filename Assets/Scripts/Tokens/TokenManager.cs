using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TokenManager : MonoBehaviour {

    public GameObject blankMenuToken;
    public Sprite[] characterSprites;
    public int tokensPerRow;
    public float tokenDistance;
    public Scrollbar scrollbar;

    static List<MenuToken> tokens = new List<MenuToken>();

	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < characterSprites.Length; i++)
        {
            GameObject newToken = Instantiate(blankMenuToken, blankMenuToken.transform.parent);
            newToken.transform.localPosition += new Vector3((i % 3) * tokenDistance, -(i / 3) * tokenDistance, 0);
            newToken.GetComponent<Image>().sprite = characterSprites[i];
            newToken.GetComponent<MenuToken>().id = i;
            tokens.Add(newToken.GetComponent<MenuToken>());
        }
        Destroy(blankMenuToken);
        //scrollbar.
	}

    public static MenuToken FindToken(int id)
    {
        foreach (MenuToken t in tokens)
        {
            if (t.id == id)
                return t;
        }

        return null;
    }

    
}
