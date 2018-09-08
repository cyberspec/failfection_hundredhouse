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
        public Animator animator;
        public float speedDampTime = 0.1f;

        private readonly int hashSpeedPara = Animator.StringToHash("Speed");
        private Vector3 lastPos;
        private float speed;

		private void Start()
		{
            targetBody = GameObject.Find("[VRTK_SDKManager]/[VRTK_SDKSetups]/VRSimulator/[VRSimulator_CameraRig]").transform;
            targetHead = targetBody.Find("Neck/Camera");
            targetLeftHand = targetBody.Find("LeftHand/Hand");
            targetRightHand = targetBody.Find("RightHand/Hand");

            targetBody.position = transform.position;
            targetBody.rotation = transform.rotation;

            lastPos = transform.position;
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


            speed   = (transform.position - lastPos).magnitude / Time.deltaTime;
            lastPos = transform.position;

            animator.SetFloat(hashSpeedPara, speed, speedDampTime, Time.deltaTime);
		}
	}
}
