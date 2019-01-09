using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StayAtEdgeOfScreen : MonoBehaviour
{
    public RectTransform followUI;

    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //float newWidth = (float)Screen.width / Screen.height;
        //transform.position = new Vector3(Screen.width / 2f /unitSize, 0, 0);

        transform.position = cam.ScreenToWorldPoint(followUI.position) - Vector3.forward * cam.transform.position.z;
    }
}
 