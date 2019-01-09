using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenSizer : MonoBehaviour
{
    public Transform tokenPrefab;

    public void Resize(float value)
    {
        tokenPrefab.localScale = Vector3.one * 0.35f * (1 + value);
    }
}
