using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using TMPro;

public class MainMenu : MonoBehaviourPunCallbacks
{
    public TMP_InputField nameRoom;
    public GameObject error;


    public void createRoom()
    {
        if (nameRoom.text.Length > 1)
        {
            RoomOptions roomOptions = new RoomOptions();
            roomOptions.MaxPlayers = 8;
            PhotonNetwork.CreateRoom(nameRoom.text, roomOptions);
        }
        else error.SetActive(true);
        
    }

    public void JoinRoom()
    {
        if(nameRoom.text.Length > 1) PhotonNetwork.JoinRoom(nameRoom.text);
        else error.SetActive(true);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("GameScene");
    }
}
