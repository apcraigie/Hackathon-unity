using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebcamStream : MonoBehaviour {

    public RawImage rawimage;
    void Start()
    {
        WebCamTexture webcamTexture = new WebCamTexture();
        rawimage.texture = webcamTexture;
        rawimage.material.mainTexture = webcamTexture;
        //webcamTexture.deviceName = "INSERT ARDUINO SOURCE HERE";
        webcamTexture.Play();
    }
}
