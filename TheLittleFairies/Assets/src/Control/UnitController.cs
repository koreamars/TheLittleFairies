/*
 * 사용자 혹은 NPC 유닛의 객체 및 정보를 관리한다.
 * 특정 Unit 객체를 반환하거나 해당 Unit의 정보를 반환 및 처리한다.
 * */
using UnityEngine;
using System.Collections;

public class UnitController : MonoBehaviour {
    /*
    private static UnitController instance;
    private static GameObject container;
    public static UnitController GetInstance()
    {
        if (!instance)
        {
            container = new GameObject();
            container.name = "UnitController";
            instance = container.AddComponent(typeof(UnitController)) as UnitController;
        }
        return instance;
    }

    public bool isTest;

    GameObject _testUnit;

#if UNITY_EDITOR
    void Start()
    {
        Logger.GetInstance().Send("UnitController.Start");
        if (isTest) {
            CreateUnit();
        }
    }
#endif

    public void CreateUnit()
    {
        Logger.GetInstance().Send("UnitController.CreateUnit");
        _testUnit = Instantiate(Resources.Load("Test/Charactor/CharactorUnit", typeof(GameObject))) as GameObject;
        _testUnit.AddComponent<NPCUnit>();

        _testUnit.transform.localPosition = new Vector3(_testUnit.transform.localPosition.x, _testUnit.transform.localPosition.y - 260f, _testUnit.transform.localPosition.z);

        NPCUnitModel testModel = new NPCUnitModel();
        testModel.moveSpeed = 2f;
        NPCUnit currentNPCUnit = _testUnit.GetComponent<NPCUnit>();
        currentNPCUnit.SetModel(testModel);
        currentNPCUnit.Show();

    }
    */

#if UNITY_EDITOR
    void OnGUI()
    {
        if (GUI.Button(new Rect(20, 40, 80, 20), "<<"))
        {
           // _testUnit.GetComponent<NPCUnit>().SetAction(NPCActionType.LEFT_MOVE);
        }

        if (GUI.Button(new Rect(20, 70, 80, 20), ">>"))
        {
           // _testUnit.GetComponent<NPCUnit>().SetAction(NPCActionType.RIGHT_MOVE);
        }

        if (GUI.Button(new Rect(20, 100, 80, 20), "idle"))
        {
           // _testUnit.GetComponent<NPCUnit>().SetAction(NPCActionType.IDLE);
        }
    }

#endif

}
