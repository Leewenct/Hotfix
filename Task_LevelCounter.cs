using UnityEngine;

[AddComponentMenu("触发器结果/触发器内部事件/关卡计数器", 0)]
public class Task_LevelCounter : TaskCellBase
{
	public enum OpType
	{
		Add,
		Minus,
		Assign
	}

	public string counter;

	public OpType opType;

	public int target;

	protected override void OnExecute()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0003: Not a type handle*/;
	}

	public Task_LevelCounter()
	{
		/*Error: Invalid field token*/;
	}
}
