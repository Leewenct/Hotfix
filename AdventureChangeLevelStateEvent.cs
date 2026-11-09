public class AdventureChangeLevelStateEvent : BaseAdventureEvent
{
	public HotfixEnum.levelState levelState;

	public bool clearMonster;

	public static AdventureChangeLevelStateEvent Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe AdventureChangeLevelStateEvent()
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
	}
}
