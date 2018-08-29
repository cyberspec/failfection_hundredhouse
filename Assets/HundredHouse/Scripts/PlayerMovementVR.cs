using UnityEngine;

namespace HundredHouse
{
    public class PlayerMovementVR : MonoBehaviour
    {
        public Transform head;
        public Transform leftHand;
        public Transform rightHand;
        public Transform targetBody;
        public Transform targetHead;
        public Transform targetLeftHand;
        public Transform targetRightHand;

		private void Start()
		{
            targetBody = GameObject.Find("[VRTK_SDKManager]/[VRTK_SDKSetups]/VRSimulator/[VRSimulator_CameraRig]").transform;
            targetHead = targetBody.Find("Neck/Camera");
            targetLeftHand = targetBody.Find("LeftHand/Hand");
            targetRightHand = targetBody.Find("RightHand/Hand");

            targetBody.position = transform.position;
            targetBody.rotation = transform.rotation;
		}

		private void Update()
		{
            transform.position = targetBody.position;
            transform.rotation = targetBody.rotation;
            head.position = targetHead.position;
            head.rotation = targetHead.rotation;
            leftHand.position = targetLeftHand.position;
            leftHand.rotation = targetLeftHand.rotation;
            rightHand.position = targetRightHand.position;
            rightHand.rotation = targetRightHand.rotation;
		}
	}
}
