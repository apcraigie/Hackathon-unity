using UnityEngine;
using System.Collections;
using System.Threading;
using System.IO.Ports;

public class Sendingtake2 : MonoBehaviour {

	//public static SerialPort sp = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
	public static SerialPort sp = new SerialPort("COM6", 115200);

	// Use this for initialization
	void Start () {
		OpenConnection();
	}


	void Update(){
		if (Input.GetKeyDown (KeyCode.W)) {
			moveForward ();
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			moveBack ();
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			turnRight ();
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			turnLeft ();
		}
	}

	public void OpenConnection() 
	{
		if (sp != null) 
		{
			if (sp.IsOpen) 
			{
				sp.Close();
				print("Closing port, because it was already open!");
			}
			else 
			{
				sp.Open();  // opens the connection
				sp.ReadTimeout = 16;  // sets the timeout value before reporting error
				print("Port Opened!");
				//		message = "Port Opened!";
			}
		}
		else 
		{
			if (sp.IsOpen)
			{
				print("Port is already open");
			}
			else 
			{
				print("Port == null");
			}
		}
	}

	void OnApplicationQuit() 
	{
		sp.Close();
	}

	public static void moveForward()
	{
		char temp = (char)0;
		sp.Write (temp.ToString());
	}
	public static void moveBack()
	{
		char temp = (char)1;
		sp.Write (temp.ToString());
	}
	public static void turnLeft()
	{
		char temp = (char)2;
		sp.Write (temp.ToString());
	}
	public static void turnRight()
	{
		char temp = (char)3;
		sp.Write (temp.ToString());
	}
	public static void armUp()
	{
		char temp = (char)4;
		sp.Write (temp.ToString());
	}
	public static void armDown()
	{
		char temp = (char)5;
		sp.Write (temp.ToString());
	}

	public static void magnetOn()
	{
		char temp = (char)6;
		sp.Write (temp.ToString());
	}
	public static void magnetOff()
	{
		char temp = (char)7;
		sp.Write (temp.ToString());
	}
}
