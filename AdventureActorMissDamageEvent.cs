using System.Collections.Generic;

public class AdventureActorMissDamageEvent : BaseAdventureEvent
{
	public LogicEntity from;

	public LogicEntity to;

	public AdventureWeapon weapon;

	public DamageType attackType;

	public int hitDamageConfigId;

	public IList<int> hitDamageTag;

	public HotfixEnum.elementType elementType;

	public int uniqueAttackId;

	public static AdventureActorMissDamageEvent Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe AdventureActorMissDamageEvent()
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
