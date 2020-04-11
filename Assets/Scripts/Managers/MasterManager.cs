using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Singletons/MasterManager")]
public class MasterManager : SingletonScriptableObject<MasterManager>
{
	#region Variables
	[SerializeField] private GameSettings _gameSettings;
	#endregion

	#region Properties
	public static GameSettings GameSettings => Instance._gameSettings;
	#endregion
}
