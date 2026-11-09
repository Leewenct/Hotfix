using System.Collections.Generic;

public class AdventureActorReceiveDamageForEffectEvent : BaseAdventureEvent
{
	public LogicEntity from;

	public LogicEntity to;

	public AdventureWeapon weapon;

	public DamageType attackType;

	public long damage;

	public long damageToShieldAndHp;

	public long damageToHp;

	public bool isCrit;

	public bool isDodge;

	public HotfixEnum.elementType elementType;

	public bool damageShield;

	public bool isKill;

	public int hitDamageId;

	public IList<int> hitDamageTag;

	public int uniqueAttackId;

	public int onceAttackTargetCount;

	public HotfixEnum.skillSlotType skillSlotType;

	public long areaEffectId;

	public int skillId;

	public bool isEnterLostCtr;

	public LostControlType lostControlType;

	public long damageToughness;

	public HotfixEnum.damageType damageType;

	public static AdventureActorReceiveDamageForEffectEvent Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe AdventureActorReceiveDamageForEffectEvent()
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
