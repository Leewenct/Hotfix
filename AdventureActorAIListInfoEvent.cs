using System.Collections.Generic;

public class AdventureActorAIListInfoEvent : BaseAdventureEvent
{
	public long monsterId;

	public Dictionary<int, List<int>> sequenceDict;

	public Dictionary<int, List<Dictionary<int, bool>>> poolBranchDict;

	public static AdventureActorAIListInfoEvent Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe AdventureActorAIListInfoEvent()
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
