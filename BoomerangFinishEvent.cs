using TrueSync;

public class BoomerangFinishEvent : BaseAdventureEvent
{
	public AdventureActor owner;

	public TSVector2 position;

	public string tag;

	public bool catchSucess;

	public static BoomerangFinishEvent Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe BoomerangFinishEvent()
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
