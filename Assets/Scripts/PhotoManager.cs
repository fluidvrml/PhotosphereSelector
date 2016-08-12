using UnityEngine;
using System.Collections;

public class PhotoManager : MonoBehaviour {

    public Texture[] images;
    int index = 0;
    public Texture currTexture;

    // Use this for initialization
    void Start() {
        if (images.Length >= 0)
        {
            SetTexture(index);
        }
        else this.enabled = false;
	}

    public void CycleImage()
    {
        if (index == images.Length - 1) index = 0;
        else index++;
        SetTexture(index);
    }

    void SetTexture(int _index)
    {
        Material currSkybox = RenderSettings.skybox;
        currTexture = images[index];
        currSkybox.SetTexture("_Tex", images[_index]);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
