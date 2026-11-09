using System.Collections.Generic;

public class AdventureActorReceiveAttackEvent : BaseAdventureEvent
{
	public LogicEntity from;

	public LogicEntity firstFrom;

	public LogicEntity to;

	public AdventureWeapon weapon;

	public int hitDamageId;

	public IList<int> hitDamageTag;

	public int uniqueAttackId;

	public int onceAttackTargetCount;

	public static AdventureActorReceiveAttackEvent Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe AdventureActorReceiveAttackEvent()
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
