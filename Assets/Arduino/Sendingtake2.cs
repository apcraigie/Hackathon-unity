using UnityEngine;
using System.Collections;
using System.Threading;
using System.IO.Ports;

public class Sendingtake2 : MonoBehaviour {

	//public static SerialPort sp = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
	public static SerialPort sp = new SerialPort("COM7", 9600);
	public string message2;

	// Use this for initialization
	void Start () {
		OpenConnection();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.O)) {
			sendYellow ();
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			sendGreen ();
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

	public static void sendYellow(){
		sp.Write("o");
	}

	public static void sendGreen(){
		sp.Write("f");
		//sp.Write("\n");
	}
}
