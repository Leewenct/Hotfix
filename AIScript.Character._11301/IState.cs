using System.Runtime.CompilerServices;
using AdventureBehaviour;

namespace AIScript.Character._11301;

public class IState
{
	private fsmStatus fsmStatus;

	public AdventureActor _actor;

	public PlayerSkillCd _skillManage;

	public AimTarget _aimTarget;

	public bool IsEnd
	{
		get
		{
			nuint num = checked((nuint)/*Error near IL_0001: Stack underflow*/);
			((sbyte[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (sbyte)num;
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	public void Init(AdventureActor actor, PlayerSkillCd skillManager, AimTarget aimTarget)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
		}
		_ = -1579874820;
		/*Error near IL_000e: Unknown opcode: 0xE7*/;
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
}
