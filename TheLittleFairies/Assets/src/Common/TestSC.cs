using UnityEngine;
using System.Collections;

public class TestSC : MonoBehaviour {

    void Start()
    {
        print("??");
        Logger.Send("test!!!!!!!");
    }

    public void SetTestMsg(string msg)
    {
        Logger.Send(msg);
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, Screen.width - 10, Screen.height - 10), "test!!!");
        
    }
}
