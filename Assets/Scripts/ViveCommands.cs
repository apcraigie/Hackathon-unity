using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveCommands : MonoBehaviour {
	public static bool magIsDown;
	public static bool scoopIsDown;

	void Start()
	{
		magIsDown = false;
		scoopIsDown = false;

		//send start signals (reset magnet and arm angles, ect...);
	}

	public static void magnetOn(){
		//send on signal
		Sendingtake2.magnetOn();
	}

	public static void magnetOff(){
		//send off signal
		Sendingtake2.magnetOff();
	}
	public static void magnetArm(){
		if (magIsDown) {
			//send up signal
			magIsDown = false;
		} else {
			//end down signal
			magIsDown = true;
		}
	}

	public static void moveForward()
	{
		Sendingtake2.moveForward ();
	}
	public static void moveBack()
	{
		Sendingtake2.moveBack ();
	}
	public static void turnLeft()
	{
		Sendingtake2.turnLeft ();
	}
	public static void turnRight()
	{
		Sendingtake2.turnRight ();
	}
	public static void armUp()
	{
		Sendingtake2.armUp ();
	}
	public static void armDown()
	{
		Sendingtake2.armDown ();
	}

	/*public static void magnetOn()
	{
		Sendingtake2.magnetOn ();
	}
	public static void magnetOff()
	{
		Sendingtake2.magnetOff ();
	}*/

	public static void rotateCam()
	{
		//even more magic goes here
	}

	public static void scoopArm()
	{
		if (scoopIsDown) {
			//send up signal
			scoopIsDown = false;
		} else {
			//send down signal
			scoopIsDown = true;
		}
	}
}
