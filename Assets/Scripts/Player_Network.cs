using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player_Network : NetworkBehaviour
{

    public override void OnStartLocalPlayer()
    {
        GetComponent<PlayerMovement>().enabled = true;


    }
}