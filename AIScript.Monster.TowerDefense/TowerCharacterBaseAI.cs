using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdventureBehaviour;
using AIScript.DynamicLevel;

namespace AIScript.Monster.TowerDefense;

public class TowerCharacterBaseAI : AIBase
{
	private string fxPlace;

	private IState curState;

	private NormalAttackState normalAttackState;

	private SkillState skillState;

	private List<TowerSkillInfo> tempSkillInfos;

	private PlayFX playFX_place;

	public virtual int Skill_Normal
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public virtual List<TowerSkillInfo> SkillInfos
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public virtual Dictionary<int, Func<bool>> SkillCondition
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public unsafe TowerDefenseCharacterActor actor
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xF7*/;
		}
	}

	public virtual void OnEnable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public virtual void OnDisable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void OnStart()
	{
		/*Error: Invalid field token*/;
	}

	public void OnUpdate()
	{
		/*Error: Invalid field token*/;
	}

	private void DoMainLogic()
	{
	}

	private void MainLoop()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I4, but got Unknown
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
		case 18:
			/*Error: Invalid branch target*/;
		}
	}

	private IState GetNextState()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0003: Unknown opcode: 0xFEEC*/;
		}
	}

	private unsafe void OnActorActive(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) == 0)
		{
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
		*(IntPtr*)(nint)(/*Error near IL_0008: Stack underflow*/ | (ushort)8) = (nint)checked((short)/*Error near IL_0008: ldarga 176 (out-of-bounds)*/);
		/*Error near IL_000c: Unknown opcode: 0xAA*/;
	}

	public unsafe TowerCharacterBaseAI()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (double)(nint)unchecked((ushort)(*(ulong*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0006: Unknown opcode: 0xF0*/;
		}
	}
}
