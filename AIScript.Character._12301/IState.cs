using System.Runtime.CompilerServices;
using AdventureBehaviour;

namespace AIScript.Character._12301;

public class IState
{
	private fsmStatus fsmStatus;

	public AdventureActor _actor;

	public PlayerSkillCd _skillManage;

	public AimTarget _aimTarget;

	public unsafe bool IsEnd
	{
		get
		{
			checked
			{
				_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			}
			System.Runtime.CompilerServices.Unsafe.Read<object>((void*)(nint)/*Error near IL_0002: ldarga 248 (out-of-bounds)*/);
			/*Error near IL_0005: Unknown opcode: 0xE9*/;
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
		_ = -1436285444;
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
