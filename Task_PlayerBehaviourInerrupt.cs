using UnityEngine;

[AddComponentMenu("触发器结果/玩家事件/中断恢复玩家操作", 0)]
public class Task_PlayerBehaviourInerrupt : TaskCellBase
{
	public enum inputType
	{
		[InspectorName("中断")]
		Pause,
		[InspectorName("恢复")]
		Resume
	}

	public inputType _inputType;

	protected override void OnExecute()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public Task_PlayerBehaviourInerrupt()
	{
		/*Error: Invalid field token*/;
	}
}
