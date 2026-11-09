using System.Collections.Generic;

public class AdventureActorReceiveDamageBeforeHitEvent : BaseAdventureEvent
{
	public LogicEntity from;

	public LogicEntity firstFrom;

	public LogicEntity to;

	public AdventureWeapon weapon;

	public DamageType attackType;

	public int hitDamageConfigId;

	public IList<int> hitDamageTag;

	public HotfixEnum.elementType elementType;

	public int uniqueAttackId;

	public int onceAttackTargetCount;

	public HotfixEnum.skillSlotType skillSlotType;

	public long areaEffectId;

	public HotfixEnum.perkSlot perkSlot;

	public HotfixEnum.damageType damageType;

	public static AdventureActorReceiveDamageBeforeHitEvent Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe AdventureActorReceiveDamageBeforeHitEvent()
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
