using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CharacterArea : ScrollRect
{
    // Start is called before the first frame update
    void Start()
    {
        RectTransform gridRect = GetComponentInChildren<GridLayoutGroup>().GetComponent<RectTransform>();
        int children = gridRect.transform.childCount;

        gridRect.sizeDelta = new Vector2(120, Mathf.CeilToInt(children / 4f) * 40);
    }

    public override void OnBeginDrag(PointerEventData eventData) { }
    public override void OnDrag(PointerEventData eventData) { }
    public override void OnEndDrag(PointerEventData eventData) { }
}
