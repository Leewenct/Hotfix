public class AdventureBeforeSwitchPlayerActor : BaseAdventureEvent
{
	public AdventureActor enterActor;

	public static AdventureBeforeSwitchPlayerActor Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe AdventureBeforeSwitchPlayerActor()
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
		*(int*)(nint)/*Error near IL_0002: Stack underflow*/ = (int)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}
}
