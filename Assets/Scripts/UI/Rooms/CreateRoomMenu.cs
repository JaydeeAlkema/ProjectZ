using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreateRoomMenu : MonoBehaviourPunCallbacks
{
	[SerializeField] private TextMeshProUGUI _roomName;
	private RoomsCanvases _roomsCanvases;

	public void FirstInitialize(RoomsCanvases canvases)
	{
		_roomsCanvases = canvases;
	}

	public void OnClick_CreateRoom()
	{
		// Check if the client is connected. 
		if(!PhotonNetwork.IsConnected)
			return;

		// Check if the room name input field is not empty.
		if(_roomName.text == "")
			return;

		// Join or Create Room
		RoomOptions options = new RoomOptions { MaxPlayers = 4 };
		PhotonNetwork.JoinOrCreateRoom(_roomName.text, options, TypedLobby.Default);
	}

	public override void OnCreatedRoom()
	{
		Debug.Log("created room succesfully.", this);
		_roomsCanvases.CurrentRoomCanvas.Show();
	}

	public override void OnCreateRoomFailed(short returnCode, string message)
	{
		Debug.Log("Room creation failed: " + message, this);
	}
}
