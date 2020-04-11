﻿using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionTest : MonoBehaviourPunCallbacks
{
	private void Start()
	{
		Debug.Log("Connecting to server...");
		PhotonNetwork.NickName = MasterManager.GameSettings.Nickname;
		PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion;
		PhotonNetwork.ConnectUsingSettings();
	}

	public override void OnConnectedToMaster()
	{
		Debug.Log("Connected to server!");
		Debug.Log(PhotonNetwork.LocalPlayer.NickName);
	}

	public override void OnDisconnected(DisconnectCause cause)
	{
		Debug.Log("Disconnected from server for reason " + cause.ToString());
	}
}
