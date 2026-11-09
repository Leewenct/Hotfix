using UnityEngine;

public class TriggerTask : LogicEntity
{
	public enum RunType
	{
		[InspectorName("顺序执行")]
		sequence,
		[InspectorName("并行执行")]
		parallel
	}

	public int templeteId;

	public RunType _runType;

	[Space]
	public TaskCellBase[] taskCells;

	[HideInInspector]
	public GameObject triggerOwner;

	private TriggerCom _triggeCom;

	private int _triggerCount;

	private int _taskCount;

	public TriggerCom triggeCom
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	protected override void OnInit()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: Unknown opcode: 0xE8*/;
		}
	}

	protected override void OnActive()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ == 0)
		{
			/*Error near IL_0002: Invalid field token*/;
		}
		switch ((int)/*Error near IL_000e: Stack underflow*/)
		{
		default:
			/*Error: End of method reached without returning.*/;
		}
	}

	protected override void OnLogicUpdate()
	{
	}

	protected override void OnDeactive()
	{
	}

	public void OnTriggerTask(GameObject owner, TriggerCom tri)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (ushort)unchecked(checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public void OnTriggerNextTask()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (ushort)unchecked(checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private bool TaskRuning()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		case 2:
			/*Error: Invalid branch target*/;
		case 3:
			/*Error: Invalid branch target*/;
		case 4:
			/*Error: Invalid branch target*/;
		case 5:
			/*Error: Invalid branch target*/;
		case 6:
			/*Error: Invalid branch target*/;
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		case 10:
			/*Error: Invalid branch target*/;
		case 11:
			/*Error: Invalid branch target*/;
		case 12:
			/*Error: Invalid branch target*/;
		case 13:
			/*Error: Invalid branch target*/;
		case 14:
			/*Error: Invalid branch target*/;
		case 15:
			/*Error: Invalid branch target*/;
		case 16:
			/*Error: Invalid branch target*/;
		case 17:
			/*Error: Invalid branch target*/;
		}
	}

	public TriggerTask()
	{
		/*Error: Invalid field token*/;
	}
}
