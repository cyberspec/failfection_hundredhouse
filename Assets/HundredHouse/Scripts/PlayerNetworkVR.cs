using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.AI;
using UnityEngine.EventSystems;

namespace HundredHouse
{
    public class PlayerNetworkVR : NetworkBehaviour
    {
	    public override void OnStartLocalPlayer()
		{
            GetComponent<PlayerMovementVR>().enabled = true;
		}
	}
}
