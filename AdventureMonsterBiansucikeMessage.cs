public class AdventureMonsterBiansucikeMessage : BaseAdventureEvent
{
	public string operationType;

	public long monsterId;

	public static AdventureMonsterBiansucikeMessage Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe AdventureMonsterBiansucikeMessage()
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
		/*Error near IL_0001: Unknown opcode: 0xE1*/;
	}
}
