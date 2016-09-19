/*
 * 각종 로그를 노출 및 관리 합니다.
 * */
using UnityEngine;
using System.Collections;

public class Logger : MonoBehaviour {
    
    private static ArrayList _msgList;
    
    public static void Send(string msg)
    {
        if (_msgList == null)
        {
            _msgList = new ArrayList();
        }

        if (_msgList.Count > 30) _msgList.RemoveAt(0);
        _msgList.Add(msg);

#if UNITY_EDITOR
        Debug.Log(msg);
#endif
    }

}
