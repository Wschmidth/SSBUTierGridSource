using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSomethingOnOff : MonoBehaviour
{
    public GameObject[] toggles;
    public GameObject[] turnOff;
    public GameObject[] turnOn;

    public void OnMouseDown()
    {
        foreach (GameObject obj in toggles)
            obj.SetActive(!obj.activeSelf);

        foreach (GameObject obj in turnOff)
            obj.SetActive(false);

        foreach (GameObject obj in turnOn)
            obj.SetActive(true);
    }
}
