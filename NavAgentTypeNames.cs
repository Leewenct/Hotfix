using System.Collections.Generic;
using Pathfinding;
using Pathfinding.RVO;
using TrueSync;

public static class NavAgentTypeNames
{
	public enum NavigationUpdateQualityLevel
	{
		LowQualityNavigationUpdate,
		MedQualityNavigationUpdate,
		GoodQualityNavigationUpdate,
		HighQualityNavigationUpdate
	}

	private static Dictionary<string, int> _nameToIDDict;

	private static Dictionary<int, string> _idToNameDict;

	public static readonly GraphMask HumanoidGraphMask;

	public static readonly GraphMask FlyingGraphMask;

	public const RVOLayer PlayerAgentLayerMask = (RVOLayer)1;

	public const RVOLayer PlayerAgentCollidesWithLayerMask = (RVOLayer)7;

	public static readonly int PlayerAgentPriority;

	public static readonly FP PlayerAgentDamp;

	public const RVOLayer MonsterAgentLayerMask = (RVOLayer)4;

	public const RVOLayer MonsterAgentCollidesWithLayerMask = (RVOLayer)7;

	public static readonly int MonsterAgentPriority;

	public static readonly FP MonsterAgentDamp;

	public static readonly int UnmoveableAgentPriority;

	public static readonly FP UnmoveableAgentDamp;

	public static void Initialize()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe static int GetAgentIDFromName(string name)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xC9*/;
	}

	public unsafe static string GetAgentNameFromID(int id)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xC9*/;
	}

	static NavAgentTypeNames()
	{
		/*Error: Unknown opcode: 0xEC*/;
	}
}
