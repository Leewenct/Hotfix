using AdventureBehaviour;

namespace AIScript.Character._15501;

public class Action_L : AIBase
{
	private int skill_1;

	private int skill_2;

	private int skill_3;

	private int skill_4;

	private int atkEvt;

	private int rushBeginEvt;

	private int rushEndEvt;

	private int relaxBeginEvt;

	private int skillEvt;

	private PlayerAdventureActor _summoner;

	private PlayerAdventureActor mainCtrActor;

	private AimTarget aimTarget;

	private IState_UAV curState;

	private RelaxState_L relaxState;

	private BattleState_L battleState;

	private BattleIdleState_L battleIdleState;

	private TraceState_L traceState;

	private RushState_L traceRushState;

	private PlayFX playFx_Rush;

	private PlayFX playFx_Rush2;

	private PlayFX playFx_Idle;

	private PlayFX playFx_Idle2;

	private PlayFX playFx_Relax;

	private PlayFX playFx_Relax2;

	public void OnEnable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void OnDisable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void OnStart()
	{
		/*Error: Read out of bounds.*/;
	}

	public void OnStop()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected Obj, but got I
		/*Error near IL_0002: Not a type handle*/;
	}

	public void OnUpdate()
	{
		/*Error: Read out of bounds.*/;
	}

	private unsafe void DoMainLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected I4, but got I8
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		*(sbyte*)(nint)/*Error near IL_0008: Stack underflow*/ = (sbyte)checked((ulong)/*Error near IL_0007: Stack underflow*/);
		_ = ((sbyte[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/];
		_ = ~/*Error near IL_0009: ldarg 213 (out-of-bounds)*/;
		/*Error near IL_000c: Unknown opcode: 0xFB*/;
	}

	private void MainLoop()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected I4, but got Unknown
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
		case 17:
			/*Error: Invalid branch target*/;
		case 18:
			/*Error: Invalid branch target*/;
		case 19:
			/*Error: Invalid branch target*/;
		case 20:
			/*Error: Invalid branch target*/;
		case 21:
			/*Error: Invalid branch target*/;
		case 22:
			/*Error: Invalid branch target*/;
		}
	}

	private IState_UAV GetNextState()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected I4, but got Unknown
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
		case 17:
			/*Error: Invalid branch target*/;
		case 18:
			/*Error: Invalid branch target*/;
		case 19:
			/*Error: Invalid branch target*/;
		case 20:
			/*Error: Invalid branch target*/;
		case 21:
			/*Error: Invalid branch target*/;
		case 22:
			/*Error: Invalid branch target*/;
		case 23:
			/*Error: Invalid branch target*/;
		case 24:
			/*Error: Invalid branch target*/;
		case 25:
			/*Error: Invalid branch target*/;
		case 26:
			/*Error: Invalid branch target*/;
		case 27:
			/*Error: Invalid branch target*/;
		case 28:
			/*Error: Invalid branch target*/;
		case 29:
			/*Error: Invalid branch target*/;
		case 30:
			/*Error: Invalid branch target*/;
		case 31:
			/*Error: Invalid branch target*/;
		case 32:
			/*Error: Invalid branch target*/;
		case 33:
			/*Error: Invalid branch target*/;
		case 34:
			/*Error: Invalid branch target*/;
		case 35:
			/*Error: Invalid branch target*/;
		case 36:
			/*Error: Invalid branch target*/;
		case 37:
			/*Error: Invalid branch target*/;
		case 38:
			/*Error: Invalid branch target*/;
		case 39:
			/*Error: Invalid branch target*/;
		}
	}

	private LogicEntity GetAttackTarget()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
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
		}
	}

	private unsafe void OnCustomEvent(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xEE*/;
	}

	public Action_L()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 8;
			/*Error near IL_0002: Unknown opcode: 0xC8*/;
		}
	}
}
