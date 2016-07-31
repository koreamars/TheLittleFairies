using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {

    private static UIController instance;
    private static GameObject container;
    public static UIController GetInstance()
    {
        if (!instance)
        {
            container = new GameObject();
            container.name = "UIController";
            instance = container.AddComponent(typeof(UIController)) as UIController;
        }
        return instance;
    }

    public bool isTest;

#if UNITY_EDITOR
    void Start()
    {
        if(isTest) {

        }
    }
#endif
}
