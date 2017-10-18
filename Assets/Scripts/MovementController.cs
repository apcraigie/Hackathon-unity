using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    private SteamVR_TrackedObject trackedObj;

    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update()
    {
        // 1
        if (Controller.GetAxis() != Vector2.zero)
        {
			if (Controller.GetAxis ().y > 0) {
				ViveCommands.moveForward ();
			}
			if (Controller.GetAxis ().y < 0) {
				//Down Move Robot Backwards
				ViveCommands.moveBack ();
			}

			if (Controller.GetAxis ().x > 0) {
				//Right Rotate Robot to the Right
				ViveCommands.turnRight ();
			}

			if (Controller.GetAxis ().x < 0) {
				//Left Rotate Robot to the Left
				ViveCommands.turnLeft ();
			}

          //  Debug.Log(gameObject.name + Controller.GetAxis());
        }

        // 2
        if (Controller.GetHairTriggerDown())
        {
            Debug.Log(gameObject.name + " Trigger Press");
            //Lift Left Arm
        }

        // 3
        if (Controller.GetHairTriggerUp())
        {
            Debug.Log(gameObject.name + " Trigger Release");
            //Release Left Arm
        }



        // 4
        if (Controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log(gameObject.name + " Grip Press");
            //Magnet ON
        }

        // 5
        if (Controller.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log(gameObject.name + " Grip Release");
            //Magnet OFF
        }
    }
}
