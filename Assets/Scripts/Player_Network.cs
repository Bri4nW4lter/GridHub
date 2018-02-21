using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.ThirdPerson;

public class Player_Network : NetworkBehaviour
{

    public override void OnStartLocalPlayer()
    {
        GetComponent<ThirdPersonCharacter>().enabled = true;


    }
}