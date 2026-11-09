using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TrueSync;

namespace AIScript.Prologue;

public class IState
{
	private fsmStatus fsmStatus;

	public LogicEntity entity;

	public PrologueMgr prologueMgr;

	private List<CoroutineNode> corList;

	private Dictionary<WorldOBB, Action<WorldOBB>> dicObb;

	private List<WorldOBB> obbs;

	public bool IsEnd
	{
		get
		{
			checked
			{
				_ = (nuint)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0002: Invalid branch target*/;
			}
		}
	}

	public SimpleMonsterAdventrueActor monsterActor
	{
		get
		{
			/*Error: Invalid metadata token*/;
		}
	}

	public SimplePlayerAdventureActor playerActor
	{
		get
		{
			/*Error: Invalid metadata token*/;
		}
	}

	public unsafe IState(LogicEntity entity, PrologueMgr prologueMgr)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public unsafe virtual void Enter()
	{
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((nuint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	public virtual void Update()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public virtual void Exit()
	{
		//Discarded unreachable code: IL_0013
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	protected void StartCor(ref CoroutineNode cor, IEnumerator enumerator)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = (ulong)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected void StopCor(ref CoroutineNode cor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = (ulong)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	public void Register(WorldOBB worldOBB, Action<WorldOBB> cb)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I4, but got Unknown
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
		}
	}

	public void Register(List<WorldOBB> worldOBBs, Action<WorldOBB> cb)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}
}
