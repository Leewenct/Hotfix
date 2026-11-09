public class FlyShieldHitEvent : BaseAdventureEvent
{
	public AdventureActor owner;

	public AdventureActor target;

	public int reboundTime;

	public static FlyShieldHitEvent Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe FlyShieldHitEvent()
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
		/*Error: Unknown opcode: 0xF0*/;
	}
}
