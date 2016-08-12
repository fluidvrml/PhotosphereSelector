using UnityEngine;
using System.Collections;

public class CardboardSwitchControl : MonoBehaviour {

    public PhotoManager photoManager;

	// Use this for initialization
	void Start () {
        if (!photoManager) photoManager = GameObject.Find("PhotoManager").GetComponent<PhotoManager>();
    }

    void OnMouseDown()
    {
        print("hi");
        if (photoManager != null) photoManager.CycleImage();
    }
	
	// Update is called once per frame
	void Update () {
        if ((Input.touchCount > 0 && photoManager != null))
        {
            foreach (Touch currTouch in Input.touches)
            {
                if (currTouch.phase == TouchPhase.Began) photoManager.CycleImage();
            }
        }
        else if (Input.GetMouseButtonDown(0) && photoManager != null) photoManager.CycleImage();
    }
}
