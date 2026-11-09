using System.Runtime.CompilerServices;
using TrueSync;
using UnityEngine;

[RequireComponent(typeof(TriggerTask))]
public class TaskCellBase : LogicMonoComponent, ILogicComponentUpdate, ILogicComponent
{
	public enum TaskStatus
	{
		active,
		runing,
		finished
	}

	protected int x;

	protected int y;

	private FP excuteTime;

	private TaskStatus taskState;

	protected FP ElapsedTime
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = ((ushort[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public TaskStatus CurrentState
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public unsafe override void OnActive()
	{
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((nuint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	public void OnLogicUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	protected virtual void OnExecute()
	{
	}

	protected virtual void LogicUpdate()
	{
	}

	protected virtual void OnStop(bool success)
	{
	}

	protected virtual void EndAction(bool success = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected I4, but got Unknown
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
		}
	}

	public bool ToExecute()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (ushort)((uint[])(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected GameObject GetOwner()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((ushort[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected int GetGlobTempleteId()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((ushort[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected long GetGlobAttributeId()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
		}
		return (long)/*OpCode not supported: Nop*/;
	}

	protected AdventureActor GetOwnerFakeActor()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			return (AdventureActor)/*OpCode not supported: Nop*/;
		}
	}

	protected TSVector2 GetSpecifyMonsterPos()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((ushort[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected static void SuspendPlayer()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected static void ResumePlayer()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected static void PauseLogic()
	{
		/*Error: Invalid metadata token*/;
	}

	protected static void ResumeLogic()
	{
		/*Error: Invalid metadata token*/;
	}

	protected static void EnterCinemaMode()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected static void ExitCinemaMode()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected static void SetHud_Visible()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected static void SetHud_Invisible()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected static void StopLevelMusic()
	{
		/*Error: Invalid metadata token*/;
	}

	protected static void PlayLevelMusic()
	{
		/*Error: Invalid metadata token*/;
	}

	protected void LogWarning(string warningText)
	{
		/*Error: Invalid field token*/;
	}

	public TaskCellBase()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid branch target*/;
		}
	}
}
