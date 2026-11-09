using System.Runtime.CompilerServices;

namespace AIScript.Character._16101.Summoned.FangWeiBiao;

public class IState
{
	private fsmStatus fsmStatus;

	public AdventureActor _actor;

	public unsafe bool IsEnd
	{
		get
		{
			//IL_0003: Expected Obj, but got I
			nuint num = checked((nuint)/*Error near IL_0001: Stack underflow*/);
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0003: Stack underflow*/, (object)num);
			System.Runtime.CompilerServices.Unsafe.Read<object>((void*)(int)(uint)/*Error near IL_0004: Stack underflow*/);
			/*Error near IL_0005: Unknown opcode: 0xE9*/;
		}
	}

	public void Init(AdventureActor actor)
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
}
