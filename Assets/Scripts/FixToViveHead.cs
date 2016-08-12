using UnityEngine;
using System.Collections;

public class FixToViveHead : MonoBehaviour {

    public Transform viveHead;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (viveHead)
        {
            transform.position = viveHead.position;
        }
	}
}
