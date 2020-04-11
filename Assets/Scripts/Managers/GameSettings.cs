using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Manager/GameSettings")]
public class GameSettings : ScriptableObject
{
	#region Variables
	[SerializeField] private string _gameVersion = "0.0.0";
	[SerializeField] private string _nickname = "DevJ";
	#endregion

	#region Properties
	public string GameVersion { get => _gameVersion; }
	public string Nickname { get => _nickname + Random.Range(0, int.MaxValue).ToString(); }
	#endregion
}
