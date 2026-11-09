using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "AutoBattleBalanceConfig", menuName = "BootConfig/AutoBattleBalanceConfig", order = 11)]
public class AutoBattleBalanceConfig : ScriptableObject
{
	public List<ABTeam> ABTeamlist;

	public unsafe AutoBattleBalanceConfig()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF6*/;
	}
}
