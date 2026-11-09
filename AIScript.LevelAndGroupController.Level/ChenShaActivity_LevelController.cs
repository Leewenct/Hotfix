namespace AIScript.LevelAndGroupController.Level;

public class ChenShaActivity_LevelController : LevelControllerBase
{
	private int monster_fazheng;

	private string wave_1;

	private string wave_2_1;

	private string wave_2_2;

	private string wave_3_1;

	private string wave_3_2;

	private string wave_3_3;

	private string interactiveID_1;

	private string interactiveID_2;

	private string interactiveID_3;

	private int _fazhengDeadCount;

	private string interactiveID_Dead;

	private bool isActiveWave2_1;

	protected override void OnControllerStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xEE*/;
		}
	}

	protected override void OnControllerStop()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xF0*/;
		}
	}

	private void InitActivity()
	{
		((float[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xBB*/;
	}

	protected override void OnReceiveInterActiveMessage(string message)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: Unknown opcode: 0xF6*/;
		}
	}

	private unsafe void OnWaveActived(IEvent iEvt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0003: Stack underflow*/ = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	private void OnWaveCleared(IEvent iEvt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((long[])/*Error near IL_0002: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)];
		/*Error near IL_0002: ldloc 1 (out-of-bounds)*/;
		/*Error near IL_0003: Unknown opcode: 0xB2*/;
	}

	private bool IsTrackedWave(string waveName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			switch ((sbyte)(ulong)/*Error near IL_0007: Stack underflow*/)
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
	}

	private void ActivateWave(string waveName)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void OnActorDied(IEvent iEvt)
	{
	}

	public ChenShaActivity_LevelController()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 8;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}
}
