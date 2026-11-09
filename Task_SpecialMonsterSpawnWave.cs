using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("触发器结果/怪物与陷阱/特殊刷怪波次激活(刷新怪出生位置等)", 0)]
public class Task_SpecialMonsterSpawnWave : TaskCellBase
{
	public string waveId;

	public List<WaveCfg> waves;

	protected override void OnExecute()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe Task_SpecialMonsterSpawnWave()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (byte)(ushort)(*unchecked((nint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}
}
