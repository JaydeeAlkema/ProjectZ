using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomsCanvases : MonoBehaviour
{
	#region Variables
	[SerializeField] private CreateOrJoinRoomCanvas _createOrJoinRoomCanvas;
	[SerializeField] private CurrentRoomCanvas _currentRoomCanvas;
	#endregion

	#region Properties
	public CreateOrJoinRoomCanvas CreateOrJoinRoomCanvas { get { return _createOrJoinRoomCanvas; } }
	public CurrentRoomCanvas CurrentRoomCanvas { get { return _currentRoomCanvas; } }
	#endregion

	private void Awake()
	{
		FirstInitialize();
	}

	void FirstInitialize()
	{
		CreateOrJoinRoomCanvas.FirstInitialize(this);
		CurrentRoomCanvas.FirstInitialize(this);
	}
}
