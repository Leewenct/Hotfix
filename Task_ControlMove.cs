using TrueSync;
using UnityEngine;

[AddComponentMenu("触发器结果/玩家事件/控制角色移动", 1)]
public class Task_ControlMove : TaskCellBase
{
	public TSVector2 startPosition;

	public TSVector2 targetPosition;

	public AdventureActor.MovementMode moveMode;

	public FP distance2fadeout;

	public float fadeoutDuration;

	public float fadeoutTargetAlpha;

	protected unsafe override void OnExecute()
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xFD*/;
	}

	public Task_ControlMove()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}
}
