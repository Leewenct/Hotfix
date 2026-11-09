using System.Runtime.CompilerServices;

namespace AIScript.Monster._13500020BoomGhost;

public class IState
{
	private fsmStatus fsmStatus;

	public AdventureActor _actor;

	public PlayerSkillCd _skillManage;

	public bool IsEnd
	{
		get
		{
			checked
			{
				_ = (nuint)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0002: stloc 0 (out-of-bounds)*/;
				/*Error near IL_0003: Unknown opcode: 0xEB*/;
			}
		}
	}

	public void Init(AdventureActor actor, PlayerSkillCd skillManager)
	{
		/*Error: Unknown opcode: 0xF0*/;
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
