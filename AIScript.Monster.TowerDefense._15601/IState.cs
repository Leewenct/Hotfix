using System.Runtime.CompilerServices;

namespace AIScript.Monster.TowerDefense._15601;

public class IState
{
	private fsmStatus fsmStatus;

	public AdventureActor _actor;

	public PlayerSkillCd _skillManage;

	public unsafe bool IsEnd
	{
		get
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			nuint num = checked((nuint)/*Error near IL_0001: Stack underflow*/);
			System.Runtime.CompilerServices.Unsafe.Read<object>((void*)(nint)(/*Error near IL_0004: Stack underflow*/ >> (int)((uint[])/*Error near IL_0003: Stack underflow*/)[num]));
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
