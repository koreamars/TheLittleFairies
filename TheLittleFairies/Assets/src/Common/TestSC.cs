using UnityEngine;
using System.Collections;

public class TestSC : MonoBehaviour {

    void Start()
    {
        print("??");
        Logger.GetInstance().Send("test!!!!!!!");
    }

    public void SetTestMsg(string msg)
    {
        Logger.GetInstance().Send(msg);
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, Screen.width - 10, Screen.height - 10), "test!!!");
        
    }
}
