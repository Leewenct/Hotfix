using System;
using System.Runtime.CompilerServices;
using AIScript.DynamicLevel;

namespace AIScript.Monster.TowerDefense;

public class IState
{
	private fsmStatus fsmStatus;

	public TowerDefenseCharacterActor _actor;

	public bool IsEnd
	{
		get
		{
			//IL_0003: Expected Obj, but got I
			_ = ((Array)checked((nuint)/*Error near IL_0001: Stack underflow*/)).LongLength;
			/*Error near IL_0003: Unknown opcode: 0xE2*/;
		}
	}

	public void Init(TowerDefenseCharacterActor actor)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public unsafe virtual void Enter()
	{
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((nuint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	public virtual void Update()
	{
	}

	public unsafe virtual void Exit()
	{
		*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	public virtual void ForceExit()
	{
	}
}
