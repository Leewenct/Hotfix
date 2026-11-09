using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "AutoBattleConfig", menuName = "BootConfig/AutoBattleConfig", order = 10)]
public class AdventureAutoBattleConfig : ScriptableObject
{
	[Serializable]
	public struct AutoBattleCommandStruct
	{
		public AdventureAutoBattleCommands.AutoBattleCommandType commandType;

		public float holdDuration;
	}

	public List<AutoBattleCommandStruct> autoBattleCommands;

	public List<AutoBattleCommandStruct> autoBattleCommandsDefault;

	public float decisionInterval;

	public float presetAutoBattleTime;

	public float timeScale;

	public unsafe AdventureAutoBattleConfig()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: ldloc 134 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}
}
