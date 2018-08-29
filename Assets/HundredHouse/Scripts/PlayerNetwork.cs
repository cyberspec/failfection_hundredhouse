using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.AI;
using UnityEngine.EventSystems;

namespace HundredHouse
{
    public class PlayerNetwork : NetworkBehaviour
    {
	    public override void OnStartLocalPlayer()
		{
            CameraControl cameraControl = GameObject.FindWithTag("CameraRig").GetComponent<CameraControl>();
            cameraControl.playerPosition = transform;
            cameraControl.enabled = true;

            GetComponent<NavMeshAgent>().enabled = true;
            GetComponent<PlayerMovement>().enabled = true;
            GetComponent<GameObjectActivitySaver>().enabled = true;

            EventTrigger.Entry entry = new EventTrigger.Entry();
            entry.eventID = EventTriggerType.PointerClick;
            entry.callback.AddListener((eventData) => { GetComponent<PlayerMovement>().OnGroundClick(eventData); });

            GameObject.FindWithTag("NavClickCollider").GetComponent<EventTrigger>().triggers.Add(entry);
		}
	}
}
