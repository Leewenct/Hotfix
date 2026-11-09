using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TrueSync;
using UnityEngine;

public class Gear_SpeedBand : GearBase, IDeterministicCollisionListener
{
	public FP deltaSpeedAccel;

	public FP deltaSpeedDecel;

	public FP switchInterval;

	public bool initialAccelerating;

	public GameObject fx_Accelerate;

	public GameObject fx_Decelerate;

	public GameObject fx_Switch;

	public FP time_Switch;

	public GameObject fx_AccelerateTrigger;

	public GameObject fx_DecelerateTrigger;

	private FP _switchTimer;

	private FP _switchEffectTimer;

	private AdventureFXPlayer currentFx;

	private AdventureFXPlayer currentFxTrigger;

	private Dictionary<Brick_BallBase, bool> enterStates;

	public bool isAccelerating
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool IsWaitingSwitchEffect
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	protected override void OnInit()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((double[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0L];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected override void OnActive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	protected override void OnDeactive()
	{
		//Discarded unreachable code: IL_001b
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xBB*/;
		}
	}

	protected override void OnShutdown()
	{
	}

	protected override void OnLogicUpdate()
	{
		//Discarded unreachable code: IL_0229
		/*Error: Unknown opcode: 0xEB*/;
	}

	private void SetEnterState(Brick_BallBase ball, bool istate)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got Unknown
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

	public unsafe void OnDeterministicCollisionEnter(DeterministicCollider other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xBF*/;
	}

	public void OnDeterministicCollisionStay(DeterministicCollider other)
	{
	}

	public unsafe void OnDeterministicCollisionExit(DeterministicCollider other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xBF*/;
	}

	public Gear_SpeedBand()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}
}
