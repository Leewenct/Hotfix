using System.Runtime.CompilerServices;

public class AdventureMonsterNearDeathEvent : BaseAdventureEvent
{
	public int dataID;

	public static AdventureMonsterNearDeathEvent Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe AdventureMonsterNearDeathEvent()
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
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((nuint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}
}
