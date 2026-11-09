using System.Runtime.CompilerServices;
using UnityEngine;

public static class ActorHelper
{
	public static ActorInfo GetFlowActorInfo(GameObject go)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		return (ActorInfo)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}

	public static AmmoInfo GetFlowAmmoInfo(GameObject go)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		return (AmmoInfo)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}

	public static ActorHealthInfo GetFlowHealthInfo(GameObject go)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		return (ActorHealthInfo)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}

	public static LogicVariable GetFlowLogicVariable(GameObject go)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		return (LogicVariable)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}

	public static LogicEntity GetFlowEntity(this GameObject go)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		return (LogicEntity)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}

	public unsafe static T GetLogicComponent<T>(this GameObject go) where T : ILogicComponent
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xE3*/;
	}

	public static ActorSkillManage GetPlayerSkillManageComponent(GameObject go)
	{
		/*Error: Invalid field token*/;
	}

	public static bool IsConfrontWith(this LogicEntity entityA, LogicEntity entityB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) == 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = null;
		/*Error near IL_0004: Unknown opcode: 0xF7*/;
	}

	public static bool IsNeutralWith(this LogicEntity entityA, LogicEntity entityB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) == 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = null;
		/*Error near IL_0004: Unknown opcode: 0xF7*/;
	}

	public static bool IsFriendlyWith(this LogicEntity entityA, LogicEntity entityB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) == 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = null;
		/*Error near IL_0004: Unknown opcode: 0xF7*/;
	}

	public static bool CheckTarget(this LogicEntity entityA, LogicEntity entityB, TargetType targetType)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0;
	}

	public unsafe static bool IsDead(this LogicEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = ref entity;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe static bool IsHideModel(this LogicEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = ref entity;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe static bool IsSneak(this LogicEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = ref entity;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe static bool IsHideOut(this LogicEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = ref entity;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe static bool IsSearchedImmunity(this LogicEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = ref entity;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe static bool IsBattleOut(this LogicEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = ref entity;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe static bool IsUnparalleled(this LogicEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = ref entity;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe static bool IsPenetrate(this LogicEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = ref entity;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public static bool IsViewableBy(this LogicEntity entityA, LogicEntity entityB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Not a type handle*/;
	}

	public static bool IsSummoned(this LogicEntity entity, out AdventureActor summoner, out SummonType summonType)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) != 0;
	}

	public static bool IsPlayerSummoned(this LogicEntity entity, out PlayerAdventureActor summoner, out SummonType summonType)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) != 0;
	}

	public static bool IsUseHitFromSummon(this LogicEntity entity, out AdventureActor summoner)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public static bool IsMinion(this LogicEntity entity, out AdventureActor summoner)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public static bool IsPlayerMinion(this LogicEntity entity, out PlayerAdventureActor summoner)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public unsafe static bool IsBossMonster(this LogicEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = 8;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe static bool IsEliteOrBossMonster(this LogicEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = 8;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe static bool IsObstacleOcclusion(this DeterministicCollider colliderA, DeterministicCollider colliderB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		checked
		{
			_ = (long)/*Error near IL_0003: Stack underflow*/;
			_ = 1;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}
}
