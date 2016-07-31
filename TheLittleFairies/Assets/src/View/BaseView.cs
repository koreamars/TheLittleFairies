using UnityEngine;
using System.Collections;

public class BaseView : MonoBehaviour {

    public bool isTest = false;

    protected BaseModel baseModel;

    public virtual void SetModel(BaseModel model)
    {
        baseModel = model;

    }

    public virtual void Show()
    {

    }

    public virtual void Hide()
    {

    }


}
