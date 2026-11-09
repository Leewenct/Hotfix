using System.Collections.Generic;
using TrueSync;

namespace AIScript.Monster.Template;

public class Parallel_BossRush : Parallel
{
	private static readonly FP triggerTime_ContinuousAttack;

	private static readonly FP interruptTime_ContinuousAttack;

	protected AdventureActor mainActor;

	protected MonsterAdventureActor _monster;

	private List<FP> _receiveDamageTimeList;

	public override void OnStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	private unsafe void OnActorCastSkill(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnActorCastSkillEnd(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F8, but got I4
		((double[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	protected virtual void OnActorCastSkill(AdventureActorCastSkillEvent castSkillEvent)
	{
	}

	protected virtual void OnActorCastEndSkill(AdventureActorCastSkillEndEvent castSkillEndEvent)
	{
	}

	private unsafe void OnMonsterToughtnessStateChange(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	protected virtual void OnMonsterToughtnessStateChange(MonsterToughnessStateChangeEvent toughtnessStateChangeEvent)
	{
	}

	private unsafe void OnActorReceiveDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	protected virtual void OnActorReceiveDamage(AdventureActorReceiveDamageEvent damageEvent)
	{
	}

	private unsafe void OnElementMarkTrigger(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: ldarg 3 (out-of-bounds)*/;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected virtual void OnElementMarkTrigger(AdventureElementMarkTriggerEvent elementMarkTriggerEvent)
	{
	}

	protected virtual void OnReceiveBeforeHit(IEvent evt)
	{
	}

	public override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			throw 0;
		}
	}

	public Parallel_BossRush()
	{
		/*Error: Invalid field token*/;
	}

	static Parallel_BossRush()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}
}
