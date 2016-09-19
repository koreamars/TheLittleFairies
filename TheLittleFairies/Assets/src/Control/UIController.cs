using UnityEngine;
using UnityEngine.UI;
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

    private GameObject _mainUIObj;
    private MainGameUI _mainGameUI;
    
    void Start()
    {
        if(isTest) {
            Init();
        }
    }

    public void Init()
    {
        _mainUIObj = GameObject.Find("MainGameUI");
        _mainGameUI = _mainUIObj.GetComponent<MainGameUI>();

    }
}
