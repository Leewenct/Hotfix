using System.Collections.Generic;
using AdventureBehaviour;

namespace AIScript.Character._15501;

public class ParallelScript : ParallelBase
{
	public int hitTag_LB;

	public int hitTag_LW;

	public int hitTag_Boom_1;

	public int hitTag_Boom_2;

	public int hitTag_LB_Berize_P3;

	public int hitTag_BB;

	public int hitTag_BW;

	public int hitTag_BB_Berize_P4;

	public int hitTag_MB;

	public int hitTag_MW;

	public int hitTag_MS;

	public int hitTag_SS;

	public int hitTag_SS_P25;

	public int hitTag_Ultra;

	public string runEffect;

	public string runEffect1;

	public SlotType slotType;

	public int hitTag_Mask;

	public string tipsKey_TriggerMark;

	public string areaEffect_Mask;

	private const int perkId_41 = 515541;

	private const int buff_41 = 15541011;

	private const int perkId_42 = 515542;

	private const int once_42 = 15542001;

	private int buff_42;

	private const int perkId_43 = 515543;

	private const int once_43 = 15543001;

	private int buffId_F1;

	private int once_F2;

	private int buffId_F3;

	private int buffId_F4;

	private int buffId_F5;

	public PlayerSkillCd skillMgr;

	public PlayerAdventureActor mainCtrActor;

	public List<PlayFX> playFxList;

	public PlayFX playFX_Run;

	public PlayFX playFX_Run1;

	public float defaultScale;

	public override void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public override void OnDisable()
	{
		//Discarded unreachable code: IL_022d
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected I, but got I8
		_ = /*Error near IL_0004: Stack underflow*/+ ((sbyte[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private unsafe void OnPrefectDodge(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xFB*/;
	}

	private unsafe void OnCastSkill(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnCastEndSkill(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F8, but got I4
		((double[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnReceiveAttack(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (int)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	private unsafe void OnReceiveDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	private unsafe void OnFinishReload(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
	}

	private unsafe void OnAreaEffectBegin(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0x78*/;
	}

	private void OnAreaEffectFinish(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private unsafe void OnReceiveBeforeHit(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (byte)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	private unsafe void OnReceiveCrit(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private unsafe void OnBattleReady(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(int*)(int)(*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnCustomEvent(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xEE*/;
	}

	private unsafe void OnAnimatorStateEnter(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF0*/;
	}

	private unsafe void OnAnimatorStateExit(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF1*/;
	}

	private void OnElementMarkTrigger(IEvent evt)
	{
		/*OpCode not supported: DebugBreak*/;
		if ((int)/*Error near IL_0001: ldloc 2 (out-of-bounds)*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		checked
		{
			_ = (byte)/*Error near IL_0008: Stack underflow*/;
			/*Error near IL_0008: Unknown opcode: 0xC5*/;
		}
	}

	private unsafe void OnGetBuff(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nuint)(*unchecked((int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public virtual void OnPrefectDodge(AdventurePerfectDodgeTrigger evt)
	{
	}

	public virtual void OnCastSkill(AdventureActorCastSkillEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected I4, but got Unknown
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
		}
	}

	public virtual void OnCastEndSkill(AdventureActorCastSkillEndEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0x24*/;
		}
	}

	public virtual void OnHurt(AdventureActorReceiveDamageEvent evt)
	{
	}

	public virtual void OnBeforeHit(AdventureActorReceiveDamageBeforeHitEvent evt, MonsterAdventureActor monster, bool isSelf)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected I4, but got Unknown
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
		}
	}

	public virtual void OnHitPre(AdventureActorReceiveAttackEvent evt, MonsterAdventureActor monster, bool isSelf)
	{
	}

	public virtual void OnHitPost(AdventureActorReceiveDamageEvent evt, MonsterAdventureActor monster, bool isSelf)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 204 (out-of-bounds)*/;
			_ = -1;
			/*Error near IL_0004: Unknown opcode: 0xEE*/;
		}
	}

	public virtual void OnTriggerMasked(AdventureActor actor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public virtual void OnCrit(AdventureActorReceiveCritDamageEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I4, but got Unknown
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
		}
	}

	public virtual void OnAreaEffectBegin(AdventureAreaEffectBeginEvent evt)
	{
	}

	public virtual void OnAreaEffectFinish(AdventureAreaEffectFinishEvent evt)
	{
	}

	public virtual void OnBattleReady(AdventureBattleReadyEvent evt)
	{
	}

	public virtual void OnCustomEvent(AdventureActorCustomEvent evt)
	{
	}

	public virtual void OnAnimatorStateEnter(AdventureActorAnimatorStateEnterEvent evt)
	{
	}

	public virtual void OnAnimatorStateExit(AdventureActorAnimatorStateExitEvent evt)
	{
	}

	public virtual void OnElementMarkTrigger(AdventureElementMarkTriggerEvent evt)
	{
	}

	public virtual void OnGetBuff(AdventureActorGetBuff evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xF3*/;
		}
	}

	private unsafe bool TriggerMask(MonsterAdventureActor monster, IList<int> hitDamageTag)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xA9*/;
	}

	public unsafe ParallelScript()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}
}
