using UnityEngine;
using System.Collections;
using Spine.Unity;
using Spine;

public class SpineTextureChange : MonoBehaviour {

    public static void SetSpriteChange(GameObject targetObj, int slotIndex, Sprite sprite, Skin skin)
    {
        /*
        SkeletonRenderer skeletonRenderer = targetObj.GetComponent<SkeletonRenderer>();

        Attachment prevAttachment = skeletonRenderer.skeleton.GetAttachment(slotIndex, "eye/type_00/eye_c");

        Attachment attachment = skeletonRenderer.skeleton.Data.AddUnitySprite(slotIndex, sprite, skin);

        skeletonRenderer.skeleton.SetAttachment(slotIndex, sprite.name);
         * */
    }
}
