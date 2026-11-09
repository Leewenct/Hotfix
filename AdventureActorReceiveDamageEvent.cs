using System;
using System.Collections.Generic;
using TrueSync;

public class AdventureActorReceiveDamageEvent : BaseAdventureEvent
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

	public int damageToughness;

	public HotfixEnum.damageType damageType;

	public FP addEnergyForMainControl;

	public readonly Dictionary<int, int> fromOnceAttrIds;

	public readonly Dictionary<int, int> toOnceAttrIds;

	public static AdventureActorReceiveDamageEvent Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe AdventureActorReceiveDamageEvent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = 6;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
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
