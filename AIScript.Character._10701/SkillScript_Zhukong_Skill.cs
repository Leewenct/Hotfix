using AdventureBehaviour;
using TrueSync;

namespace AIScript.Character._10701;

public class SkillScript_Zhukong_Skill : SkillAdvancedBase
{
	private readonly ComboInputBuffer.ActionKey[] actionKeys_Loop;

	private readonly ComboInputBuffer.ActionKey[] actionKeys_Attack;

	private const string atkTag_01 = "107_Main_P01_StrengthenAttack";

	private const string actionKeys_Loop_03 = "107_Main_P03_StrengthenLoop";

	private const int holdShield_AddInvincible = 10793012;

	private const int holdShield_AddWeightBuffId = 10793013;

	private const int holdShield_ReduceDamageBuffId = 10793011;

	private readonly FP skillTime;

	private const int reduceCDPercent = 100;

	protected int _curReduceDamageBuffId;

	protected int _beginSecondStage;

	protected AimTarget _aimTarget;

	protected PlayerSkillCd _skillManager;

	protected FP _originRunAnimationSpd;

	protected bool _searchUseInputDirection;

	protected FP leftTime;

	private PlayFX fxP;

	private PlayFX playFX;

	private long areaId_04;

	private bool beInviceHit;

	private bool hasPlayArea;

	protected override void OnSkillEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		((short[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = 0;
		_ = /*Error near IL_0004: Stack underflow*/+ /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public virtual void OnStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((long[])/*Error near IL_0004: Stack underflow*/)[((byte[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0]];
		/*Error near IL_0004: Unknown opcode: 0xED*/;
	}

	public void OnUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/ + 1678767215;
		}
	}

	protected void SearchTargetAndAim()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected I4, but got Unknown
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
		case 40:
			/*Error: Invalid branch target*/;
		case 41:
			/*Error: Invalid branch target*/;
		case 42:
			/*Error: Invalid branch target*/;
		case 43:
			/*Error: Invalid branch target*/;
		case 44:
			/*Error: Invalid branch target*/;
		case 45:
			/*Error: Invalid branch target*/;
		case 46:
			/*Error: Invalid branch target*/;
		case 47:
			/*Error: Invalid branch target*/;
		case 48:
			/*Error: Invalid branch target*/;
		case 49:
			/*Error: Invalid branch target*/;
		case 50:
			/*Error: Invalid branch target*/;
		case 51:
			/*Error: Invalid branch target*/;
		case 52:
			/*Error: Invalid branch target*/;
		case 53:
			/*Error: Invalid branch target*/;
		case 54:
			/*Error: Invalid branch target*/;
		case 55:
			/*Error: Invalid branch target*/;
		case 56:
			/*Error: Invalid branch target*/;
		case 57:
			/*Error: Invalid branch target*/;
		}
	}

	protected virtual void CounterAttack(bool iPlus = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	protected virtual void AfterCounterAttack()
	{
	}

	protected unsafe override void OnReceiveAttack(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (int)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	protected unsafe void OnDeathHit(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	protected void OnFinish()
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	protected void OnInterrupt()
	{
		/*Error: Read out of bounds.*/;
	}

	protected override void OnSkillDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		((sbyte[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = 0;
		_ = /*Error near IL_0004: Stack underflow*/+ /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public SkillScript_Zhukong_Skill()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}
}
