using UnityEngine;
using System.Collections;

public class MainGameUI : MonoBehaviour {

	
    public void LeftMoveBtn(bool isDown)
    {
        Logger.Send("LeftMoveBtn " + isDown);
    }

    public void RightMoveBtn(bool isDown)
    {
        Logger.Send("RightMoveBtn " + isDown);
    }

    public void MainUtilBtn(bool isDown)
    {
        Logger.Send("MainUtilBtn " + isDown);
    }

    public void SubUtil1Btn(bool isDown)
    {
        Logger.Send("SubUtil1Btn " + isDown);
    }

    public void SubUtil2Btn(bool isDown)
    {
        Logger.Send("SubUtil2Btn " + isDown);
    }

}
