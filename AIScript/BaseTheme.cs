using System.Collections;
using System.Collections.Generic;
using TrueSync;

namespace AIScript;

public class BaseTheme
{
	private readonly Dictionary<int, FP> _perkTriggerTimeDic;

	protected AdventureActor _actor
	{
		get
		{
			/*Error: Invalid metadata token*/;
		}
	}

	protected FP LogicDeltaTime
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = (nuint)unchecked((int)((byte[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0]);
				/*Error near IL_0004: Unknown opcode: 0xEC*/;
			}
		}
	}

	public virtual void OnEnable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public virtual void OnDisable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected bool GetPerkLv(int perkId, out int lv)
	{
		/*Error: Invalid metadata token*/;
	}

	private unsafe void OnTriggerCharGamePlayLogicCommonEvent(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xBD*/;
	}

	private unsafe void OnCastSkill(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnReceiveNoDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (long)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
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

	private unsafe void OnReceiveHit(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (ushort)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	private unsafe void OnReceiveCrit(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private unsafe void OnBulletFinish(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xB1*/;
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

	private void OnSwitchActor(IEvent evt)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		/*OpCode not supported: DebugBreak*/;
		_ = /*Error near IL_0001: ldloc 2 (out-of-bounds)*/% /*Error near IL_0002: ldloc 1 (out-of-bounds)*/;
	}

	protected virtual void OnPerk_NormalAtk()
	{
	}

	protected virtual void OnPerk_Dodge()
	{
	}

	protected virtual void OnPerk_CastSkill()
	{
	}

	protected virtual void OnPerk_CastAssistSkill()
	{
	}

	protected virtual void OnCrit(AdventureActorReceiveCritDamageEvent _evt)
	{
	}

	protected virtual void OnNoDmgHit(AdventureActorNoDamageEvent _evt)
	{
	}

	protected virtual void OnHitPre(AdventureActorReceiveDamageBeforeSettlementEvent _evt)
	{
	}

	protected virtual void OnHitPost(AdventureActorReceiveDamageEvent _evt)
	{
	}

	protected virtual void OnMonsterKilled(AdventureActorReceiveDamageEvent _evt)
	{
	}

	protected virtual void OnBeforeHit(AdventureActorReceiveDamageBeforeHitEvent _evt)
	{
	}

	protected virtual void OnBeforeHurt(AdventureActorReceiveDamageBeforeHitEvent _evt)
	{
	}

	protected virtual void OnHurt(AdventureActorReceiveDamageEvent _evt)
	{
	}

	protected virtual void OnBulletFinish(AdventureBulletFinishEvent _evt)
	{
	}

	protected virtual void OnSwitchActor(AdventureSWICH_PLAYER_ACTOR _evt)
	{
	}

	protected void TriggerPerk(int perkId)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected bool CheckPerkCDTimeout(int perkId, FP cd)
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

	protected bool CheckPerkCD(int perkId, FP cd)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	protected bool CanTriggerPerk(int perkId, out int lv, FP cd)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void ModifyPerkCD(int perkId, FP reduceCd)
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

	protected unsafe void ClearAllPerkCD()
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0003: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0005: ldarg 2 (out-of-bounds)*/;
		_ = 8;
		/*Error near IL_0007: Unknown opcode: 0x77*/;
	}

	protected CoroutineNode StartLogicCoroutine(IEnumerator enumerator, bool runImmediately = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nuint)unchecked((int)((byte[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0]);
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected void StopLogicCoroutine(CoroutineNode coroutine)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nuint)unchecked((int)((byte[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0]);
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected void AddKey(string key)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void DelKey(string key)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected int GetKeyCount(string key)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void ClearKey(string key)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public BaseTheme()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 649257824280361434L + /*Error near IL_000a: ldarga 100 (out-of-bounds)*/;
			/*Error near IL_000d: Invalid branch target*/;
		}
	}
}
