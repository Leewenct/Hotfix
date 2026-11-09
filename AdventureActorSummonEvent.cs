public class AdventureActorSummonEvent : BaseAdventureEvent
{
	public int summonId;

	public AdventureActor summoner;

	public static AdventureActorSummonEvent Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe AdventureActorSummonEvent()
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
		/*Error: Invalid field token*/;
	}
}
