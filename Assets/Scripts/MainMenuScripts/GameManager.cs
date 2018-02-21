using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GridFighter
{ 
    public class GameManager :Photon.PunBehaviour {

        public static GameManager instance;

        private void Awake()
        {
            if(instance != null)
            {
                DestroyImmediate(gameObject);
                return;
            }

            DontDestroyOnLoad(gameObject);
            instance = this;

            PhotonNetwork.automaticallySyncScene = true; // Client läd automatisch die gleiche Szene wie der Host
        }

        private void Start()
        {
            PhotonNetwork.ConnectUsingSettings("GridFighter_V0.1");
        }

        public void JoinGame()
        {
            RoomOptions roomOptions = new RoomOptions();
            roomOptions.maxPlayers = 2;
            PhotonNetwork.JoinOrCreateRoom("Default Room", roomOptions, null);
        }

        public override void OnJoinedRoom()
        {
            Debug.Log("Joined Room");
            if (PhotonNetwork.isMasterClient)
            {
                PhotonNetwork.LoadLevel("GameScene");
            }
        }
    }
}