using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    private UnitController _unitController;
    private UIController _uiController;
    private MapController _mapController;

	// Use this for initialization
	void Start () {
        _uiController = UIController.GetInstance();
        _unitController = UnitController.GetInstance();
        _mapController = MapController.GetInstance();

        _uiController.Init();
        _unitController.CreateUnit();
	}
	
}
