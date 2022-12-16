using System.Collections;
using System.IO;
using UnityEngine;
using SimpleFileBrowser;
using HumanPoseUtil;

public class Demo : MonoBehaviour
{
    [SerializeField] Animator TargetAnimator;

    public void Import()
    {
        if (TargetAnimator == null) return;

        FileBrowser.SetFilters(true, new FileBrowser.Filter("Pose Json", ".json"));
        FileBrowser.SetDefaultFilter(".json");

        FileBrowser.ShowLoadDialog((paths) =>
        {
            if (paths.Length > 0)
            {
                string json = File.ReadAllText(paths[0]);
                HumanPose pose = JsonUtility.FromJson<HumanPose>(json);
                TargetAnimator.runtimeAnimatorController = null;
                HumanPoseUtility.ApplyHumanPose(TargetAnimator, pose);
            }
        }, () =>
        {
            Debug.Log("OnCancel");
        }, FileBrowser.PickMode.Files, false, null, null);
    }

    public void Export()
    {
        if (TargetAnimator == null) return;

        HumanPose pose = HumanPoseUtility.ExtractHumanPose(TargetAnimator);
        string json = JsonUtility.ToJson(pose, false);

        FileBrowser.SetFilters(true, new FileBrowser.Filter("Pose Json", ".json"));
        FileBrowser.SetDefaultFilter(".json");

        FileBrowser.ShowSaveDialog((paths) =>
        {
            if (paths.Length > 0)
            {
                File.WriteAllText(paths[0], json);
            }
        }, () =>
        {
            Debug.Log("OnCancel");
        }, FileBrowser.PickMode.Files, false, null, null);
    }
}
