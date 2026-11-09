using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AIScript.Disc;

public class DiscScriptBase : AIBase
{
	public void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			if (false)
			{
			}
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private void OnPrefectDodge(IEvent evt)
	{
		/*OpCode not supported: DebugBreak*/;
		if (/*Error near IL_0004: Stack underflow*/ > /*Error near IL_0001: ldloc 2 (out-of-bounds)*/)
		{
			/*Error: Invalid branch target*/;
		}
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

	private unsafe void OnBeforeHit(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (byte)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
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

	private unsafe void OnDied(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((byte[])/*Error near IL_0003: Stack underflow*/)[*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)];
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnLevelStateChange(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(short*)(int)(*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: Invalid field token*/;
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

	private unsafe void OnActorEnter(IEvent _evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_ = 8;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private unsafe void OnActorLeave(IEvent _evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_ = 1;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private unsafe void OnActorDied(IEvent _evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((byte[])/*Error near IL_0003: Stack underflow*/)[*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)];
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnToughnessState(IEvent _evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public unsafe void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		_ = 2u;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected int GetSkillLevel(int discId, int skillid1, int skillid2 = 0, int skillid3 = 0)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected bool GetSkillLevel(int discId, int skillId_1, int skillId_2, int skillId_3, out int skillLevel)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected (int, int) GetDiscInfo(int discId, List<int> skills)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected int GetDiscSkillv(int discId, List<int> skills)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected void AddBuffToGroup(int buffId)
	{
		//Discarded unreachable code: IL_0010
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void AddBuffToMainControl(int buffId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
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

	protected void AddBuffToSupport(int buffId)
	{
		//Discarded unreachable code: IL_000e, IL_0010
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected virtual void OnDiscEnable()
	{
	}

	protected virtual void OnDiscDisable()
	{
	}

	protected virtual void OnPerfectDodge(AdventurePerfectDodgeTrigger evt)
	{
	}

	protected virtual void OnCastSkill(AdventureActorCastSkillEvent castSkillEvent)
	{
	}

	protected virtual void OnCastEndSkill(AdventureActorCastSkillEndEvent castSkillEvent)
	{
	}

	protected virtual void OnPlayerActorCastSkill(PlayerAdventureActor actor, AdventureActorCastSkillEvent castSkillEvent)
	{
	}

	protected virtual void OnMainPlayerActorCastSkill(PlayerAdventureActor actor, AdventureActorCastSkillEvent castSkillEvent)
	{
	}

	protected virtual void OnPlayerActorCastSkillEnd(PlayerAdventureActor actor, AdventureActorCastSkillEndEvent castSkillEvent)
	{
	}

	protected virtual void OnMainPlayerActorCastSkillEnd(PlayerAdventureActor actor, AdventureActorCastSkillEndEvent castSkillEvent)
	{
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

	protected virtual void OnReceiveAttack(AdventureActorReceiveAttackEvent damageEvt, MonsterAdventureActor monster)
	{
	}

	protected virtual void OnBeforeHit(AdventureActorReceiveDamageBeforeHitEvent damageEvent)
	{
	}

	protected virtual void OnBeforePlayerActorHit(PlayerAdventureActor actor, MonsterAdventureActor target, AdventureActorReceiveDamageBeforeHitEvent damageEvent)
	{
	}

	protected virtual void OnBeforeMainPlayerActorHit(PlayerAdventureActor actor, MonsterAdventureActor target, AdventureActorReceiveDamageBeforeHitEvent damageEvent)
	{
	}

	protected virtual void OnReceiveDamage(AdventureActorReceiveDamageEvent damageEvent)
	{
	}

	protected virtual void OnPlayerActorDamaged(PlayerAdventureActor actor, MonsterAdventureActor target, AdventureActorReceiveDamageEvent damageEvent)
	{
	}

	protected virtual void OnPlayerReceiveDamaged(AdventureActor damageSource, PlayerAdventureActor actor, AdventureActorReceiveDamageEvent damageEvent)
	{
	}

	protected virtual void OnMainPlayerActorDamaged(PlayerAdventureActor actor, MonsterAdventureActor target, AdventureActorReceiveDamageEvent damageEvent)
	{
	}

	protected virtual void OnMainPlayerActorReceiveDamage(AdventureActor damageSource, PlayerAdventureActor actor, AdventureActorReceiveDamageEvent damageEvent)
	{
	}

	protected virtual void OnDied(AdventureActorDiedEvent diedEvent)
	{
	}

	protected virtual void OnPlayerActorKill(PlayerAdventureActor actor, MonsterAdventureActor target, AdventureActorDiedEvent diedEvent)
	{
	}

	protected virtual void OnMainPlayerActorKill(PlayerAdventureActor actor, MonsterAdventureActor target, AdventureActorDiedEvent diedEvent)
	{
	}

	protected virtual void OnLevelSuccess()
	{
	}

	protected virtual void OnElementMarkTrigger(AdventureElementMarkTriggerEvent _evt)
	{
	}

	protected virtual void OnFirstEnterBattleState(IEvent evt)
	{
	}

	protected virtual void OnActorEnter(AdventurePlayerEnterEvent evt)
	{
	}

	protected virtual void OnActorLeave(AdventurePlayerLeaveEvent evt)
	{
	}

	protected virtual void OnActorDied(AdventureActorDiedEvent evt)
	{
	}

	protected virtual void OnToughnessState(MonsterToughnessStateChangeEvent evt)
	{
	}

	public DiscScriptBase()
	{
		/*Error: Invalid field token*/;
	}
}
