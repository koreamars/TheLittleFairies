using UnityEngine;
using System.Collections;

public class TestSC : MonoBehaviour {

    public void SetTest(string msg)
    {
        Debug.Log(msg);
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, Screen.width - 10, Screen.height - 10), "test!!!");
    }
}
