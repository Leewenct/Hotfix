using System;
using System.Collections;
using System.Runtime.CompilerServices;
using AdventureBehaviour;
using TrueSync;

namespace AIScript.Character._15501;

public class IState_UAV
{
	private fsmStatus fsmStatus;

	public AdventureActor _actor;

	public AdventureActor _summoner;

	public AimTarget _aimTarget;

	public PlayFX playFx_Rush;

	public PlayFX playFx_Rush2;

	public PlayFX playFx_Idle;

	public PlayFX playFx_Idle2;

	public PlayFX playFx_Relax;

	public PlayFX playFx_Relax2;

	public bool IsEnd
	{
		get
		{
			checked
			{
				_ = (nuint)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0002: Invalid metadata token*/;
			}
		}
	}

	public void Init(AdventureActor actor, AdventureActor summoner, AimTarget aimTarget, PlayFX playRush = null, PlayFX playRush2 = null, PlayFX playIdle = null, PlayFX playIdle2 = null, PlayFX playRelax = null, PlayFX playRelax2 = null)
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
		_ = -1161951748;
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

	public virtual void ForceExit(bool keepAim = false)
	{
	}

	protected void StartCoroutine(ref CoroutineNode coroutineNode, IEnumerator enumerator)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected I4, but got Unknown
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
		}
	}

	protected void StopCoroutine(ref CoroutineNode coroutineNode)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected I4, but got Unknown
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
		}
	}

	protected unsafe TSVector2 GetRandomPos()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = (nint)/*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xAC*/;
	}

	public unsafe IState_UAV()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected native int or pointer, but got F8
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if ((nuint)(nint)(*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)) > (nuint)(*(sbyte*)(nint)(~-4.966524744724468E-63)))
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0013: Stack underflow*/| /*Error near IL_0013: Stack underflow*/;
		/*Error near IL_0013: Unknown opcode: 0xF0*/;
	}
}
