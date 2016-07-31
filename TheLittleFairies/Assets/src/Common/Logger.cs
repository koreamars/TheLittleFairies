/*
 * 각종 로그를 노출 및 관리 합니다.
 * */
using UnityEngine;
using System.Collections;

public class Logger : MonoBehaviour {

    public static void Send(string msg)
    {
#if UNITY_EDITOR
        Debug.Log(msg);
#endif
    }
}
