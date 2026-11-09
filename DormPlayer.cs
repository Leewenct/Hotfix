using System.Runtime.CompilerServices;
using UnityEngine;

public class DormPlayer : DormActor
{
	private bool _modeStatePending;

	private DormActorState _pendingModeState;

	protected override bool blockOtherActorsHard
	{
		get
		{
			/*Error: Unknown opcode: 0xC0*/;
		}
	}

	protected override float rvoPriority
	{
		get
		{
			_ = ((short[])/*Error near IL_0002: Stack underflow*/)[((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/]];
			/*Error near IL_0002: stloc 3 (out-of-bounds)*/;
			/*Error near IL_0003: Read out of bounds.*/;
		}
	}

	protected override float walkSpeed
	{
		get
		{
			_ = ((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0001: Unknown opcode: 0xE5*/;
		}
	}

	protected override float runSpeed
	{
		get
		{
			_ = ((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0001: Unknown opcode: 0xC0*/;
		}
	}

	protected override void RegisterFSM()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public void OnMovementInput(bool movementHasInput, Vector2 movementInputDirection, bool bWalk = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 210 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xFB*/;
		}
	}

	protected override void EnterModeDefault()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = ((object[])/*Error near IL_0004: Stack underflow*/)[checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0)];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected override void EnterModeVisitor()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = ((object[])/*Error near IL_0004: Stack underflow*/)[checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0)];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected override void EnterModeView()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = ((object[])/*Error near IL_0004: Stack underflow*/)[checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0)];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private void SwitchStateOrDeferWhilePerforming(DormActorState target)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = ((object[])/*Error near IL_0004: Stack underflow*/)[checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0)];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private bool IsPlayingSpecialIdle()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = ((object[])/*Error near IL_0004: Stack underflow*/)[checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0)];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private void TryConsumePendingModeState(bool interruptPerformance = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected I4, but got Unknown
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
		case 15:
			/*Error: Invalid branch target*/;
		case 16:
			/*Error: Invalid branch target*/;
		}
	}

	private unsafe void DiscardPendingModeState()
	{
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((nuint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	protected override void Update()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Unknown opcode: 0xA8*/;
	}

	public void RequestTurnToFace(Vector3 targetPos)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = ((object[])/*Error near IL_0004: Stack underflow*/)[checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0)];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public override void InterWithObjeComplete()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected I4, but got Unknown
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
		}
	}

	public override void ResetToSpawnState()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = ((object[])/*Error near IL_0004: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) | 0];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected void WwiseEvent(string eventName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = ((object[])/*Error near IL_0004: Stack underflow*/)[checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0)];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public DormPlayer()
	{
		/*Error: Invalid field token*/;
	}
}
