using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{


    public int r;
    public int g;
    public int b;
    public SpriteRenderer[] sprites;
    public Text[] texts;

    void Update()
    {
        foreach (SpriteRenderer rend in sprites)
        {
            rend.color = new Color(r / 10f, g / 10f, b / 10f, 1);
        }
        foreach (Text text in texts)
        {
            text.color = new Color(r / 10f, g / 10f, b / 10f, 1);
        }
    }

    public void ChangeR(float value)
    {
        r = Mathf.RoundToInt(value);
    }

    public void ChangeG(float value)
    {
        g = Mathf.RoundToInt(value);
    }

    public void ChangeB(float value)
    {
        b = Mathf.RoundToInt(value);
    }
}
