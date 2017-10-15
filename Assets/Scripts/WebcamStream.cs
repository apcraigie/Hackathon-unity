using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebcamStream : MonoBehaviour {

    public RawImage rawimage;
    public Camera VRHead;

    Vector3 CamRot;
    void Start()
    {
        WebCamTexture webcamTexture = new WebCamTexture();
        rawimage.texture = webcamTexture;
        rawimage.material.mainTexture = webcamTexture;
        //webcamTexture.deviceName = "INSERT ARDUINO SOURCE HERE";
        webcamTexture.Play();

        Transform vrrot;
        vrrot = VRHead.transform;
        CamRot = new Vector3(vrrot.rotation.x, vrrot.rotation.y, vrrot.rotation.z);
    }
}
