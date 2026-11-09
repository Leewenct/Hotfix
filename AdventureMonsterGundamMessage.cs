using TrueSync;

public class AdventureMonsterGundamMessage : BaseAdventureEvent
{
	public string operationType;

	public long monsterId;

	public int skillId;

	public int skillType;

	public bool brokenOthers;

	public bool isNextHandSkill;

	public int handCount;

	public TSVector2 selectPosition;

	public long bodyId;

	public int actionPhase;

	public int cooperateType;

	public static AdventureMonsterGundamMessage Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe AdventureMonsterGundamMessage()
	{
		switch (*(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/)
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		}
	}

	public unsafe override void Clear()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xA7*/;
	}
}
