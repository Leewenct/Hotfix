using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class TargetFilterCriteriaInfo
{
	[Serializable]
	public class TargetFilterCriteria
	{
		public TargetTypeMapping targetType;

		public ElementTypeMapping elementType;

		public MonsterEpicTypeMapping monsterEpicType;

		[Space]
		public OperationType operationType;

		public TargetFilterCriteria()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = (ushort)0;
				/*Error near IL_0004: Unknown opcode: 0xEC*/;
			}
		}
	}

	[Flags]
	public enum TargetTypeMapping
	{
		Owner = 2,
		Teammate = 4,
		Friend = 8,
		Enemy = 0x10,
		Both = 0x20,
		OwnerSummoned = 0x40,
		TeammateSummoned = 0x80,
		FriendSummoned = 0x100,
		EnemySummoned = 0x200,
		BothSummoned = 0x400,
		MainPlayerActor = 0x800,
		AssitPlayerActor = 0x1000,
		TeammateWithoutSummoned = 0x2000,
		TeammateWithoutNotMinionSummoned = 0x4000,
		FriendWithoutSummoned = 0x8000,
		None = 0,
		All = Owner | Teammate | Friend | Enemy | Both | OwnerSummoned | TeammateSummoned | FriendSummoned | EnemySummoned | BothSummoned | MainPlayerActor | AssitPlayerActor | TeammateWithoutSummoned | TeammateWithoutNotMinionSummoned | FriendWithoutSummoned
	}

	[Flags]
	public enum ElementTypeMapping
	{
		WE = 2,
		FE = 4,
		SE = 8,
		AE = 0x10,
		LE = 0x20,
		DE = 0x40,
		NONE = 0x80,
		None = 0,
		All = WE | FE | SE | AE | LE | DE | NONE
	}

	[Flags]
	public enum MonsterEpicTypeMapping
	{
		NORMAL = 2,
		ELITE = 4,
		LEADER = 8,
		LORD = 0x10,
		None = 0,
		All = NORMAL | ELITE | LEADER | LORD
	}

	public enum OperationType
	{
		And,
		Or
	}

	public static readonly Dictionary<TargetTypeMapping, TargetType> TargetTypeCorrespondenceDic;

	public static readonly Dictionary<ElementTypeMapping, HotfixEnum.elementType> ElementTypeCorrespondenceDic;

	public static readonly Dictionary<MonsterEpicTypeMapping, HotfixEnum.monsterEpicType> MonsterEpicTypeCorrespondenceDic;

	public List<TargetFilterCriteria> filterCriteriaList;

	[Space]
	public OperationType operationType;

	public bool CheckFilterCriteria(LogicEntity self, LogicEntity target)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) != 0;
	}

	private static bool Operation(bool resultA, bool resultB, OperationType operationType)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0003: Stack underflow*/ <= (/*Error near IL_0001: Stack underflow*/ & /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Unknown opcode: 0xCE*/;
	}

	private static bool CheckTargetType(LogicEntity A, LogicEntity B, TargetTypeMapping targetTypeMapping)
	{
		//Discarded unreachable code: IL_001a, IL_002e
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 205 (out-of-bounds)*/;
			KeyValuePair<TargetTypeMapping, TargetType> keyValuePair = (KeyValuePair<TargetTypeMapping, TargetType>)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Not a type handle*/;
		}
	}

	private static bool CheckElementType(LogicEntity target, ElementTypeMapping elementTypeMapping)
	{
		//Discarded unreachable code: IL_0024, IL_003f
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 205 (out-of-bounds)*/;
			Dictionary<ElementTypeMapping, HotfixEnum.elementType>.Enumerator enumerator = (Dictionary<ElementTypeMapping, HotfixEnum.elementType>.Enumerator)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Not a type handle*/;
		}
	}

	private static bool CheckMonsterType(MonsterAdventureActor monster, MonsterEpicTypeMapping monsterEpicTypeMapping)
	{
		//Discarded unreachable code: IL_0017
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 205 (out-of-bounds)*/;
			KeyValuePair<MonsterEpicTypeMapping, HotfixEnum.monsterEpicType> keyValuePair = (KeyValuePair<MonsterEpicTypeMapping, HotfixEnum.monsterEpicType>)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	unsafe static TargetFilterCriteriaInfo()
	{
		//IL_0002: Expected Obj, but got I4
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)(*(short*)(nint)/*Error near IL_0001: Stack underflow*/));
		_ = (ushort)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xE6*/;
	}
}
