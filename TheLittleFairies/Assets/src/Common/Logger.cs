/*
 * 각종 로그를 노출 및 관리 합니다.
 * */
using UnityEngine;
using System.Collections;

public class Logger : MonoBehaviour {

    private static Logger instance;
    private static GameObject container;
    public static Logger GetInstance()
    {
        if (!instance)
        {
            container = new GameObject();
            container.name = "Logger";
            instance = container.AddComponent(typeof(Logger)) as Logger;
        }
        return instance;
    }

    private ArrayList _msgList;

    public void Send(string msg)
    {
        if(_msgList == null)
        {
            _msgList = new ArrayList();
        }

        if (_msgList.Count > 30) _msgList.RemoveAt(0);
        _msgList.Add(msg);

#if UNITY_EDITOR
        Debug.Log(msg);
#endif
    }


    void OnGUI ()
    {
        if(_msgList != null && _msgList.Count > 0)
        {
            string totalMsg = "";
            foreach(string thisMsg in _msgList)
            {
                totalMsg += thisMsg + "\n";
            }
            GUI.Label(new Rect(10, 10, Screen.width - 10, Screen.height - 10), totalMsg);
        }
    }

}
