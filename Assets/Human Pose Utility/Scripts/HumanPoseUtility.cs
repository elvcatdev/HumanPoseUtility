using UnityEngine;

namespace HumanPoseUtil
{
    public static class HumanPoseUtility
    {
        private static HumanPose _poseForGetting;
        private static Vector3 _prevPos = Vector3.zero;
        private static Quaternion _prevRot = Quaternion.identity;

        public static HumanPose ExtractHumanPose(Animator anim)
        {
            _prevPos = anim.transform.position;
            _prevRot = anim.transform.rotation;

            anim.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);

            var handler = new HumanPoseHandler(anim.avatar, anim.transform);
            handler.GetHumanPose(ref _poseForGetting);

            anim.transform.SetPositionAndRotation(_prevPos, _prevRot);

            return _poseForGetting;
        }

        public static void ApplyHumanPose(Animator anim, HumanPose pose)
        {
            var handler = new HumanPoseHandler(anim.avatar, anim.transform);
            handler.SetHumanPose(ref pose);
        }
    }
}
