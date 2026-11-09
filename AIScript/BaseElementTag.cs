using System.Collections.Generic;

namespace AIScript;

public class BaseElementTag
{
	protected PlayerAdventureActor _actor;

	protected MonsterAdventureActor _monster;

	public Dictionary<long, int> actorFilterDic;

	public virtual void OnEnable()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public virtual void OnDisable()
	{
	}

	public void OnBeHit(AdventureActorReceiveDamageBeforeSettlementEvent evt, PlayerAdventureActor actor, MonsterAdventureActor monster)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/!= 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			_ = ~(nint)(-1003619836);
			/*Error near IL_000e: Unknown opcode: 0xE7*/;
		}
	}

	public void OnEvent(AdventureElementMarkTriggerEvent evt, PlayerAdventureActor actor, MonsterAdventureActor monster)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/!= 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			_ = ~(nint)(-1003619836);
			/*Error near IL_000e: Unknown opcode: 0xE7*/;
		}
	}

	protected virtual void OnBeHitTrigger(AdventureActorReceiveDamageBeforeSettlementEvent evt)
	{
	}

	protected virtual void OnEventTrigger(AdventureElementMarkTriggerEvent evt)
	{
	}

	public unsafe BaseElementTag()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (short)(*unchecked((nuint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}
}
