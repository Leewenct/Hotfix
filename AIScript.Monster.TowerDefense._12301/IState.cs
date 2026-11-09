using System.Runtime.CompilerServices;

namespace AIScript.Monster.TowerDefense._12301;

public class IState
{
	private fsmStatus fsmStatus;

	public AdventureActor _actor;

	public PlayerSkillCd _skillManage;

	public unsafe bool IsEnd
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.Read<object>((void*)(checked((nuint)/*Error near IL_0001: Stack underflow*/) >> (int)/*Error near IL_0002: ldloc 1 (out-of-bounds)*/));
			/*Error near IL_0005: Unknown opcode: 0xE9*/;
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
