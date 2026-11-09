using TrueSync;

public class AdventureMonsterSwitchDurationStateEvent : BaseAdventureEvent
{
	public bool breakCurrentAction;

	public bool breakForceControl;

	public int lastStateIndex;

	public int nextStateIndex;

	public FP durationTime;

	public static AdventureMonsterSwitchDurationStateEvent Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe AdventureMonsterSwitchDurationStateEvent()
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
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}
}
