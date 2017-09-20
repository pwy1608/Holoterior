using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleWindowAR : MonoBehaviour {

    struct Log
    {
        public string mesage;
        public string stackTrace;
        public LogType type;
    }

    private Text text;
    List<Log> logs = new List<Log>();
    GameObject consoleTextWindow;
    GameObject consoleCanvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
