using UnityEngine;
using System.Collections;

public class MapController : MonoBehaviour {

    private static MapController instance;
    private static GameObject container;
    public static MapController GetInstance()
    {
        if (!instance)
        {
            container = new GameObject();
            container.name = "MapController";
            instance = container.AddComponent(typeof(MapController)) as MapController;
        }
        return instance;
    }
}
