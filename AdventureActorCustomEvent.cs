using System.Collections.Generic;
using TrueSync;

public class AdventureActorCustomEvent : BaseAdventureEvent
{
	public AdventureActor actor;

	public string eventName;

	public int eventHashCode;

	public List<int> intParamList;

	public List<string> stringParamList;

	public List<TSVector2> tsVector2ParamList;

	public bool boolParam;

	public FP fpParam;

	public int intParam;

	public LogicEntity target;

	public static AdventureActorCustomEvent Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe AdventureActorCustomEvent()
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
