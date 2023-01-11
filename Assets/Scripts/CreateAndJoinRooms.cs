using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public TMPro.TMP_InputField createInput;
    public TMPro.TMP_InputField joinInput;
    public TMPro.TMP_InputField nickNameInput;

    public void CreateRoom()
    {
        Debug.Log(PhotonNetwork.NickName);
        if (PhotonNetwork.NickName != "")
        {
            PhotonNetwork.CreateRoom(createInput.text);
            PhotonNetwork.NickName = nickNameInput.text;
        }
        else
        {
            Debug.Log("nickname is null");
        }
    }
    public void JoinRoom()
    {
        if (PhotonNetwork.NickName != "")
        {
            PhotonNetwork.JoinRoom(joinInput.text);
            PhotonNetwork.NickName = nickNameInput.text;
        }
        else
        {
            Debug.Log("nickname is null");
        }
    }

    public void SetNickName()
    {
        PhotonNetwork.NickName = nickNameInput.text;
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
