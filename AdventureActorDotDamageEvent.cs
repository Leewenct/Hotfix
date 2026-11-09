using System.Collections.Generic;

public class AdventureActorDotDamageEvent : BaseAdventureEvent
{
	public LogicEntity from;

	public LogicEntity to;

	public DamageType attackType;

	public long damage;

	public long damageToShieldAndHp;

	public long damageToHp;

	public HotfixEnum.elementType elementType;

	public int hitDamageId;

	public IList<int> hitDamageTag;

	public long damageToughness;

	public static AdventureActorDotDamageEvent Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe AdventureActorDotDamageEvent()
	{
		switch (*(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/)
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		}
	}

	public override void Clear()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}
}
