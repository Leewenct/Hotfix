using System.Runtime.CompilerServices;
using TrueSync;
using UnityEngine;

[AddComponentMenu("游戏/冒险模块/武器组件/炸弹_触发组件(目前仅炸弹可用)")]
[RequireComponent(typeof(AdventureBomb))]
[DisallowMultipleComponent]
public class BombComponent_Trigger : LogicMonoComponent, IBombComponent, IDeterministicCollisionListener
{
	public enum TriggerType
	{
		Enter,
		Exit
	}

	public TriggerType triggerType;

	protected AdventureBomb _context;

	public bool KeepAlive
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

	public unsafe void Setup()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F8, but got I
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		*(double*)(nint)/*Error near IL_0008: Stack underflow*/ = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		_ = /*Error near IL_0009: Stack underflow*/+ /*Error near IL_0009: Stack underflow*/;
		/*Error near IL_000a: Unknown opcode: 0xAF*/;
	}

	public unsafe void Reset(LogicEntity owner = null, TSVector2 position = default(TSVector2), FP positionY = default(FP), TSVector2 direction = default(TSVector2), LogicEntity target = null, TSVector2 targetPosition = default(TSVector2), FP targetPositionY = default(FP))
	{
		*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (object)/*Error near IL_0003: Stack underflow*/;
		_ = (short)/*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: stloc 3 (out-of-bounds)*/;
		/*Error near IL_0005: Read out of bounds.*/;
	}

	public void Finish()
	{
	}

	public override void OnDeactive()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Unknown opcode: 0xCD*/;
	}

	public void OnDeterministicCollisionEnter(DeterministicCollider other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	public void OnDeterministicCollisionStay(DeterministicCollider other)
	{
	}

	public void OnDeterministicCollisionExit(DeterministicCollider other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected I4, but got Unknown
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
		}
	}

	protected void Trigger(DeterministicCollider other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected I4, but got Unknown
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
		}
	}

	public BombComponent_Trigger()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Invalid field token*/;
	}
}
