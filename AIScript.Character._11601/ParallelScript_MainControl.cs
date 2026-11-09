using System.Collections.Generic;

namespace AIScript.Character._11601;

public class ParallelScript_MainControl : ParallelScript
{
	private List<MonsterAdventureActor> _summonedList_P2;

	public override void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/< 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (int)/*Error near IL_0008: Stack underflow*/;
			/*Error near IL_0008: Metadata token must be either a methoddef, memberref or methodspec*/;
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

	private unsafe void OnRemoveBuff(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0003: Stack underflow*/+ *unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private unsafe void OnBulletBorn(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xB0*/;
	}

	private unsafe void OnBulletFinish(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xB1*/;
	}

	private unsafe void OnSummonedSpawned(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ~(*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: Invalid field token*/;
	}

	private void OnMonsterDied(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	protected unsafe override void OnBeforeSelfHit(AdventureActorReceiveDamageBeforeHitEvent beforeHitEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		//IL_007f: Invalid comparison between Unknown and I8
		//IL_0081->IL0007: Incompatible stack heights: 0 vs 1
		nuint num;
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			num = (nuint)/*Error near IL_0007: Stack underflow*/;
		}
		do
		{
			if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)num)
			{
				MonsterAdventureActor monsterAdventureActor = (MonsterAdventureActor)/*Error near IL_000a: Stack underflow*/;
				/*Error near IL_000a: Unknown opcode: 0xBD*/;
			}
		}
		while ((long)/*Error near IL_0081: Stack underflow*/ < *(long*)(nint)/*Error near IL_007f: Stack underflow*/);
		if (/*Error near IL_0086: Stack underflow*/ <= /*Error near IL_0086: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0086: Invalid metadata token*/;
	}

	protected override void OnSelfDamaged(AdventureActorReceiveDamageEvent damageEvent)
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
		_ = /*Error near IL_000a: Stack underflow*/| /*Error near IL_000a: Stack underflow*/;
		/*Error near IL_000a: Unknown opcode: 0xBD*/;
	}

	protected unsafe override bool CheckWeaponCanTriggerLandMark(AdventureWeapon hitWeapon)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xA9*/;
	}

	protected override void OnTriggerLandMark(MonsterAdventureActor monster, IList<int> hitDamageTag)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Not a type handle*/;
	}

	public unsafe override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = *(int*)null;
			_ = null;
			/*Error near IL_0004: Unknown opcode: 0xED*/;
		}
	}

	public ParallelScript_MainControl()
	{
		/*Error: Read out of bounds.*/;
	}
}
