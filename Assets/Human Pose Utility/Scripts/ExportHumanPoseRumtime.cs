using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class ExportHumanPoseRumtime : MonoBehaviour
{
    public Animator ThisAnimator;
    private HumanPose _thispose;

    public void SaveNowHumanPose()
    {
        var handler = new HumanPoseHandler(ThisAnimator.avatar, ThisAnimator.transform);
        handler.GetHumanPose(ref _thispose);

        string pose = JsonUtility.ToJson(_thispose);

        string path = "Assets/Data/PoseData.asset";
    }
}
