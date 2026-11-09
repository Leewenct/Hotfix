using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TrueSync;

namespace AIScript.Utils;

public static class CommonUtils
{
	[CompilerGenerated]
	private sealed class _003CWaitForSeconds_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FP seconds;

		public LogicEntity entity;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CWaitForSeconds_003Ed__5(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected I4, but got Unknown
			switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
			default:
				/*Error: End of method reached without returning.*/;
			case 0:
				/*Error: Invalid branch target*/;
			case 1:
				/*Error: Invalid branch target*/;
			case 2:
				/*Error: Invalid branch target*/;
			case 3:
				/*Error: Invalid branch target*/;
			case 4:
				/*Error: Invalid branch target*/;
			case 5:
				/*Error: Invalid branch target*/;
			case 6:
				/*Error: Invalid branch target*/;
			case 7:
				/*Error: Invalid branch target*/;
			case 8:
				/*Error: Invalid branch target*/;
			case 9:
				/*Error: Invalid branch target*/;
			case 10:
				/*Error: Invalid branch target*/;
			case 11:
				/*Error: Invalid branch target*/;
			case 12:
				/*Error: Invalid branch target*/;
			case 13:
				/*Error: Invalid branch target*/;
			case 14:
				/*Error: Invalid branch target*/;
			case 15:
				/*Error: Invalid branch target*/;
			case 16:
				/*Error: Invalid branch target*/;
			case 17:
				/*Error: Invalid branch target*/;
			case 18:
				/*Error: Invalid branch target*/;
			case 19:
				/*Error: Invalid branch target*/;
			case 20:
				/*Error: Invalid branch target*/;
			case 21:
				/*Error: Invalid branch target*/;
			case 22:
				/*Error: Invalid branch target*/;
			case 23:
				/*Error: Invalid branch target*/;
			case 24:
				/*Error: Invalid branch target*/;
			case 25:
				/*Error: Invalid branch target*/;
			case 26:
				/*Error: Invalid branch target*/;
			case 27:
				/*Error: Invalid branch target*/;
			case 28:
				/*Error: Invalid branch target*/;
			case 29:
				/*Error: Invalid branch target*/;
			case 30:
				/*Error: Invalid branch target*/;
			case 31:
				/*Error: Invalid branch target*/;
			case 32:
				/*Error: Invalid branch target*/;
			case 33:
				/*Error: Invalid branch target*/;
			case 34:
				/*Error: Invalid branch target*/;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitUntil_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Func<bool> predicate;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CWaitUntil_003Ed__7(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected I4, but got Unknown
			switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
			default:
				/*Error: End of method reached without returning.*/;
			case 0:
				/*Error: Invalid branch target*/;
			case 1:
				/*Error: Invalid branch target*/;
			case 2:
				/*Error: Invalid branch target*/;
			case 3:
				/*Error: Invalid branch target*/;
			case 4:
				/*Error: Invalid branch target*/;
			case 5:
				/*Error: Invalid branch target*/;
			case 6:
				/*Error: Invalid branch target*/;
			case 7:
				/*Error: Invalid branch target*/;
			case 8:
				/*Error: Invalid branch target*/;
			case 9:
				/*Error: Invalid branch target*/;
			case 10:
				/*Error: Invalid branch target*/;
			case 11:
				/*Error: Invalid branch target*/;
			case 12:
				/*Error: Invalid branch target*/;
			case 13:
				/*Error: Invalid branch target*/;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	private static List<LogicEntity> _searchResult;

	private static List<DeterministicCollider> _deterministicColliders;

	public unsafe static void SearchNearTargetsByCircleInTD(AdventureActor _actor, TSVector2 center, FP range, List<LogicEntity> entities, bool isConfront = false, bool onlyAlive = true, bool includeSelf = false, Predicate<LogicEntity> customFilter = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xC7*/;
	}

	public unsafe static List<LogicEntity> GetTargetsByFactionByTD(AdventureActor actor, bool isFriend)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xE5*/;
	}

	public unsafe static void SummonMonster(AdventureActor actor, int groupId, int monsterId, TSVector2 pos, TSVector2 dir, SummonCfg cfg = null, string summonGroupSuffix = null, Action<MonsterAdventureActor> finishCallback = null)
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xA9*/;
	}

	[IteratorStateMachine(typeof(_003CWaitForSeconds_003Ed__5))]
	public static IEnumerator WaitForSeconds(this LogicEntity entity, FP seconds)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public static CoroutineNode WaitTime(this LogicEntity entity, FP seconds)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	[IteratorStateMachine(typeof(_003CWaitUntil_003Ed__7))]
	public unsafe static IEnumerator WaitUntil(this LogicEntity entity, Func<bool> predicate)
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(uint*)(nint)/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0007: Read out of bounds.*/;
	}

	public static DeterministicShape GetDeterministicFanShape(FP radius, FP innerRadius, FP angle, TSVector2 position, FP rotation)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	public static DeterministicShape GetDeterministicCircleShape(FP radius, FP innerRadius, TSVector2 position)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	public static DeterministicShape GetDeterministicRectShape(FP width, FP length, TSVector2 position)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	public unsafe static int ParseStringParamToInt(string value)
	{
		_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xB1*/;
	}

	public static bool TryParseStringParamToInt(string value, out int intValue)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public unsafe static float ParseStringParamToFloat(string value)
	{
		_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xB1*/;
	}

	public static bool TryParseStringParamToFloat(string value, out float floatValue)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 8;
			/*Error near IL_0002: Unknown opcode: 0xB2*/;
		}
	}

	public static FP ParseStringParamToFP(string value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (short)0;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public static bool TryParseStringParamToFP(string value, out FP fpValue)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 8;
			/*Error near IL_0002: Unknown opcode: 0xB2*/;
		}
	}

	public unsafe static FP GetAttackRange(AdventureActor actor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe static bool HaveTargetAndInAttackRange(AdventureActor actor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	public unsafe static FP GetAimRange(AdventureActor actor)
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		actor = (AdventureActor)/*Error near IL_0005: Stack underflow*/;
		return (FP)/*Error near IL_0005: ldarg 2 (out-of-bounds)*/;
	}

	public static TSVector2 GetMainControlSkillDirection(AdventureActor actor)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static bool CheckHitByTag(IList<int> hitDamageTags, int hitTag)
	{
		/*Error near IL_0002: Invalid branch target*/;
	}

	public unsafe static LogicEntity SearchNearTargetByCircle(AdventureActor _actor, FP radius, bool isConfront = true, bool includeSelf = false)
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xB1*/;
	}

	[Obsolete("废弃使用，禁止函数内部使用new list")]
	public unsafe static List<LogicEntity> SearchNearTargetsByCircle(AdventureActor _actor, FP radius, bool isConfront, bool includeSelf)
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xAF*/;
	}

	public unsafe static void SearchNearTargetsByCircle(AdventureActor _actor, TSVector2 center, FP radius, bool isConfront, bool includeSelf, List<LogicEntity> entities)
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xAD*/;
	}

	public unsafe static void SearchNearTargetsByCircle(AdventureActor _actor, FP radius, bool isConfront, bool includeSelf, List<LogicEntity> entities)
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xAB*/;
	}

	public static void PlayOneOffFx(AdventureActor actor, string fxAliasOrPath)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: starg 6 (out-of-bounds)*/;
		/*Error near IL_0009: Unknown opcode: 0xE6*/;
	}

	public static bool CheckTalentByIndex(PlayerTalentGroupType talentGroupType, int index)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	public static TSVector2 RandomReachablePointInsideRing(AdventureActor actor, TSVector2 center, FP innerRadius, FP outerRadius, int maxCheckCount = 30)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public static TSVector2 RandomReachablePointInsideRingS(AdventureActor actor, TSVector2 center, FP innerRadius, FP outerRadius, FP rotation, FP range, int maxCheckCount = 30)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public static TSVector2 RandomReachablePointInsideFan(AdventureActor actor, TSVector2 center, FP innerRadius, FP outerRadius, FP angleBase, FP angleRange, int maxCheckCount = 30)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public static TSVector2 RandomWalkablePointInsideRing(AdventureActor actor, TSVector2 center, FP innerRadius, FP outerRadius, int maxCheckCount = 30)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public static LogicEntity GetAssistantAttackTarget(AdventureActor actor, bool useInputDirection = false, bool activeActorTargetFirst = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got I
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 39 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
		}
		_ = ((Array)(nint)((IntPtr[])/*Error near IL_0006: Stack underflow*/)[checked((short)/*Error near IL_0005: Stack underflow*/)]).LongLength;
		/*Error near IL_0008: Unknown opcode: 0xC4*/;
	}

	public static FP GetScriptValue(AdventureActor fromActor, int parameterId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public static bool CheckElementMark(int markHash, AdventureActor target)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) != 0;
	}

	public static bool CheckTriggerElementMarkCD(AdventureActor actor, AdventureActor target, FP overrideTriggerCD = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0;
	}

	public static void TriggerElementMarkEvent(int markHash, HotfixEnum.AdventureActorElementTriggerType markTriggerType, AdventureActor triggerActor, AdventureActor markActor, string tipsKey = "")
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static HotfixEnum.elementType ConvertToElementType(int markHash)
	{
		/*Error: Unknown opcode: 0xF2*/;
	}

	public unsafe static bool HavePersonalPerk(int actorDataId, int perkId, out int perkLevel)
	{
		_ = *(uint*)(nint)/*Error near IL_0001: Stack underflow*/;
		_ = 6.584656824604839E+254;
		/*Error near IL_000a: Unknown opcode: 0xEC*/;
	}

	public unsafe static void GetMonsterTarget(AdventureActor monster)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		_ = /*Error near IL_0003: Stack underflow*/% /*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	public static bool CheckTargetIsValid(LogicEntity target, long targetId = 0L, bool ingoreSearchedImmunity = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0;
	}

	public static void EnableCrossObstacleMode(AdventureActor actor)
	{
		/*Error: Invalid field token*/;
	}

	public unsafe static bool CheckAndSetDodgeCrossObstacleMode(AdventureActor actor, FP realDodgeDistance, FP crossDodgeAdditionDistance, FP crossDodgeKeepAwayNavmeshEdgeDistance, bool forceUseForwardDirection = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		_ = /*Error near IL_0003: Stack underflow*/^ /*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe static bool CheckAndSetCrossObstacleMode(AdventureActor actor, FP realMoveDistance, FP crossMoveAdditionDistance, FP crossMoveKeepAwayNavmeshEdgeDistance, bool forceUseForwardDirection = false)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = System.Runtime.CompilerServices.Unsafe.Read<object>(unchecked((void*)checked((ulong)unchecked((uint)(*(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/))))) + forceUseForwardDirection;
			/*Error near IL_0007: Read out of bounds.*/;
		}
	}

	public static void DisableCrossObstacleMode(AdventureActor actor)
	{
		/*Error: Invalid field token*/;
	}

	public unsafe static void ClearDodgeCrossObstacleMode(AdventureActor actor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xE5*/;
	}

	public static void ClearCrossObstacleMode(AdventureActor actor)
	{
		/*Error: Invalid field token*/;
	}

	public unsafe static void GetAllSummons(List<MonsterAdventureActor> monsters)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		_ = (ulong)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: Not a type handle*/;
	}

	public unsafe static void GetAllSummonsById(List<MonsterAdventureActor> monsters, int monsterId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		_ = (ulong)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: Not a type handle*/;
	}

	public static FP GetDurationByAcc(FP acceleration, FP initialVelocity, FP maxVelocity, FP distance)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ushort)/*Error near IL_0007: Stack underflow*/;
			_ = 1689276938;
			/*Error near IL_000c: Invalid branch target*/;
		}
	}

	public unsafe static void ReduceSkillSection(AdventureActor actor, AdventureSkill skill, bool beginResume = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public static bool CheckAllPlayerActorAreSameElement(HotfixEnum.elementType elementType)
	{
		//Discarded unreachable code: IL_0010
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static int GetPlayerActorCountByElement(HotfixEnum.elementType elementType)
	{
		//Discarded unreachable code: IL_0012
		/*Error: Unknown opcode: 0xEB*/;
	}

	unsafe static CommonUtils()
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
	}
}
