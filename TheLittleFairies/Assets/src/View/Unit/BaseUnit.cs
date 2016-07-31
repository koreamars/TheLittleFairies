using Spine;
using Spine.Unity;

public class BaseUnit : BaseView {

    protected SkeletonAnimation skeletonAnimation;
    protected string currentActionType = "";

    public override void SetModel(BaseModel model)
    {
        base.SetModel(model);

        skeletonAnimation = this.GetComponent<SkeletonAnimation>();
        currentActionType = BaseActionType.IDLE;
    }

    public override void Show()
    {
        base.Show();

    }

    public virtual void SetAction(string actionType)
    {
        Logger.GetInstance().Send("BaseUnit.SetAction actionType:" + actionType);

        currentActionType = actionType;
        switch (actionType)
        {
            case BaseActionType.IDLE:
                skeletonAnimation.state.SetAnimation(0, "idle", true);
                break;
            case BaseActionType.LEFT_MOVE:
               if(this.transform.localScale.x < 0)  this.transform.localScale = new UnityEngine.Vector3(this.transform.localScale.x * -1, this.transform.localScale.y, this.transform.localScale.z);
                skeletonAnimation.state.SetAnimation(0, "run", true);
                break;
            case BaseActionType.RIGHT_MOVE:
                if (this.transform.localScale.x > 0) this.transform.localScale = new UnityEngine.Vector3(this.transform.localScale.x * -1, this.transform.localScale.y, this.transform.localScale.z);
                skeletonAnimation.state.SetAnimation(0, "run", true);
                break;
        }
    }

    protected virtual void ObjectMove()
    {
        BaseUnitModel currentModel = baseModel as BaseUnitModel;
        if (currentModel == null) return;

        UnityEngine.Vector3 movePos = this.transform.localPosition;

        switch(currentActionType) {
            case BaseActionType.LEFT_MOVE:
                movePos.x = movePos.x - currentModel.moveSpeed;
                break;
            case BaseActionType.RIGHT_MOVE:
                movePos.x = movePos.x + currentModel.moveSpeed;
                break;
        }

        this.transform.localPosition = movePos;

        UnityEngine.Vector3 cameraVector3 = this.transform.localPosition;
        cameraVector3.z = UnityEngine.Camera.main.transform.localPosition.z;
        cameraVector3.y = this.transform.localPosition.y + 60;
        UnityEngine.Camera.main.transform.localPosition = cameraVector3;
    }

    void Update()
    {
        if (currentActionType != "")
        {
            ObjectMove();
        }
        
    }
}
