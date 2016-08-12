using UnityEngine;
using System.Collections;

public class ViveSwitchControl : MonoBehaviour {

    public PhotoManager photoManager;

    // Use this for initialization
    void Start() {
        if (!photoManager) photoManager = GameObject.Find("PhotoManager").GetComponent<PhotoManager>();
        GetComponent<SteamVR_TrackedController>().TriggerClicked += new ClickedEventHandler(TriggerClick);
    }

    void TriggerClick(object sender, ClickedEventArgs e)
    {
        if (photoManager != null) photoManager.CycleImage();
    }

	// Update is called once per frame
	void Update () {
	
	}
}
