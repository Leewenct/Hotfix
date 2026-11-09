using TrueSync;
using UnityEngine;

[AddComponentMenu("触发器结果/关卡事件/触发掉落物", 0)]
public class Task_DropObject : TaskCellBase
{
	public int dropEntityGroupId;

	[SerializeField]
	[Range(0f, 1f)]
	public float dropEntityRate;

	private FP dropEntityRateFP;

	protected override void OnInit()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (ushort)((object[])(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnExecute()
	{
		//Discarded unreachable code: IL_009c
		/*Error: Unknown opcode: 0xFD*/;
	}

	private float Random(float min, float max)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0003: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Not a type handle*/;
	}

	private float Random(int min, int max)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0003: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Not a type handle*/;
	}

	public Task_DropObject()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}
}
