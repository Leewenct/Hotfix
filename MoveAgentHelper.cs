using TrueSync;

public static class MoveAgentHelper
{
	public unsafe static FP GetMaxSpeed(this AdventureActor actor)
	{
		//IL_0002: Expected F8, but got I4
		//IL_0005: Expected Obj, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		actor = (AdventureActor)8;
		/*Error near IL_0005: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_0007: Not a type handle*/;
	}

	public static void AgentMove(this AdventureActor actor, TSVector targetPos)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}
}
