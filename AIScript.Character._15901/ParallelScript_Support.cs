using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._15901;

public class ParallelScript_Support : ParallelScript
{
	private int hitTag_A;

	private int hitTag_A_P22;

	private int hitTag_B;

	private int hitTag_B_Once;

	private int hitTag_B_P30_Once;

	private int hitTag_AddMask;

	private int buff_Mask;

	private int summonEvt;

	private int maxSummonCount;

	private int buff_B;

	private int hitDmg_B;

	private int buff_MaxHitFX;

	private int buffMaxCount_B;

	private const int perkId_21 = 515921;

	private string areaEffect_21;

	private int buff_21;

	private int once_21;

	public int perkId_22;

	public string areaEffect_A_22;

	private int once_22_passive;

	private int once_22;

	private int once_22_24;

	public int perkId_23;

	public string areaEffect_B_23;

	private int once_23;

	public int perkId_24;

	public FP leftTime_24;

	private const int perkId_25 = 515925;

	private int once_25;

	private const int perkId_26 = 515926;

	private int buff_26;

	private const int perkId_27 = 515927;

	private int buff_27;

	private int hitDmg_27;

	private const string hittedFx_27 = "fx_15901_base_Skill_sup_rose_hit_perk27";

	private const int perkId_28 = 515928;

	private int once_28;

	private const int perkId_29 = 515929;

	private int once_29;

	private const int perkId_30 = 515930;

	private int hitDmg_30;

	private const string hittedFx_30 = "fx_15901_base_skill_sup_withered_hit_perk30";

	private int buff_30;

	private int once_30;

	private const int perkId_32 = 515932;

	private int buff_32;

	private const int perkId_33 = 515933;

	private int buff_33;

	private int totleCount;

	private int roseCount;

	private bool isAdd;

	private List<ShootRose> roseList;

	private ShootRose curShootRose;

	private bool allSEFriend;

	private int seFriendCount;

	private long uid;

	public override void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			int num = 0;
			/*Error near IL_0004: Unknown opcode: 0xED*/;
		}
	}

	public override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			int num = 0;
			/*Error near IL_0004: Unknown opcode: 0xED*/;
		}
	}

	public override void OnCastSkill(AdventureActorCastSkillEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ > (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_000a: Stack underflow*// /*Error near IL_000a: Stack underflow*/;
		/*Error near IL_000a: Unknown opcode: 0xBD*/;
	}

	public override void OnBeforeHit(AdventureActorReceiveDamageBeforeHitEvent evt, MonsterAdventureActor monster, bool isSelf)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected Obj, but got F8
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		this = (ParallelScript_Support)((double[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
	}

	public override void OnHitPre(AdventureActorReceiveAttackEvent evt, MonsterAdventureActor monster, bool isSelf)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected Obj, but got F8
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		this = (ParallelScript_Support)((double[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
	}

	public override void OnHitPost(AdventureActorReceiveDamageEvent evt, MonsterAdventureActor monster, bool isSelf)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected Obj, but got F8
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		this = (ParallelScript_Support)((double[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
	}

	public override void OnCustomEvent(AdventureActorCustomEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
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
		}
	}

	public override void OnAreaEffectBegin(AdventureAreaEffectBeginEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ > (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0009: Unknown opcode: 0xAC*/;
	}

	public override void OnAreaEffectFinish(AdventureAreaEffectFinishEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_0009: Unknown opcode: 0xAC*/;
		}
		_003F val = checked(/*Error near IL_007f: Stack underflow*/ + /*Error near IL_007f: Stack underflow*/);
		if ((nint)/*Error near IL_0086: Stack underflow*/ < (nint)checked((nuint)val))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0086: Invalid metadata token*/;
	}

	private unsafe void OnElementMarkTrigger(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: ldarg 3 (out-of-bounds)*/;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private void OnCountChange()
	{
	}

	public bool GetPerkByShoot(int perkId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Unknown opcode: 0xBE*/;
	}

	private long GetUid()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Not a type handle*/;
	}

	public unsafe ParallelScript_Support()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}
}
