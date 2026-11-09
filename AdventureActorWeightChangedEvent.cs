public class AdventureActorWeightChangedEvent : BaseAdventureEvent
{
	public long actorId;

	public int originWeight;

	public int finalWeight;

	public static AdventureActorWeightChangedEvent Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe AdventureActorWeightChangedEvent()
	{
		switch (*(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/)
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		}
	}
}
