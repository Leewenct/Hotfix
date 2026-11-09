using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TriggerManager : Singleton<TriggerManager>
{
	public enum ConditionType
	{
		[InspectorName("碰撞事件")]
		conditionCollider,
		[InspectorName("刷怪容器状态")]
		conditionSpawnMonster,
		[InspectorName("收到交互指令")]
		conditionOperate,
		[InspectorName("角色进入退出战斗状态")]
		conditionAttackState,
		[InspectorName("敌对怪物进入Action状态")]
		conditionMonsterActionState,
		[InspectorName("指定怪物死亡")]
		conditionSpecifyMonsterDeath,
		[InspectorName("怪物状态变化")]
		conditionSpecifyMonsterState,
		[InspectorName("关卡场景加载完毕")]
		conditionLevelLoadComplete,
		[InspectorName("关卡结束")]
		conditionLevelFinish,
		[InspectorName("关卡计数器")]
		conditionLevelCounter,
		[InspectorName("怪物HP变化")]
		conditionMonsterHp,
		[InspectorName("战斗开始后延时触发（强敌挑战专用）")]
		conditionDelayTimeWhenBattleStart,
		[InspectorName("指定Tag的怪物死亡")]
		conditionMonsterDeathByTag,
		[InspectorName("指定气泡对话播放结束")]
		conditionBubbleDialogEnd
	}

	public enum triggerState
	{
		active,
		deActive,
		pause,
		destroy,
		none
	}

	public enum colliderType
	{
		[InspectorName("角色")]
		playerSelf,
		[InspectorName("任意怪物")]
		enemy,
		[InspectorName("任意对象")]
		all
	}

	public Dictionary<string, AdventureFXPlayer> triggerFxs;

	private readonly Dictionary<string, AIAdapter> _triggerAIDict;

	public List<TriggerCom> triggerComps
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public void InitTriggerComps()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void AddTriggerFx(string tag, AdventureFXPlayer fx)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	public void DeletTriggerFx(string tag)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		this = (TriggerManager)/*Error near IL_0009: Stack underflow*/;
		/*Error near IL_0009: ldarg 2 (out-of-bounds)*/;
	}

	public void SetTrigger(TriggerCom triggerComp, bool iAdd)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public void AddTriggers(TriggerCom[] triggerComps, int x, int y)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 204 (out-of-bounds)*/;
			_ = -1;
			/*Error near IL_0004: Unknown opcode: 0xFA*/;
		}
	}

	public void SetTriggerSateByGroup(string groupTitle, triggerState state)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		state = (triggerState)/*Error near IL_0009: Stack underflow*/;
		if ((int)/*Error near IL_000b: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_000b: Not a type handle*/;
	}

	public void StartTriggerAI(string aiTypeString)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected I4, but got Unknown
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
		}
	}

	public void DisableTriggerAI(string aiTypeString)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected I4, but got Unknown
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
		}
	}

	public void LogicUpdate()
	{
		//Discarded unreachable code: IL_0011
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected I4, but got Unknown
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
		}
	}

	public void ClearTrigger()
	{
		//Discarded unreachable code: IL_0011, IL_0055
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected I4, but got Unknown
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
		}
	}

	public TriggerManager()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = -7493250302251517463L;
			/*Error near IL_000a: Unknown opcode: 0xC5*/;
		}
	}
}
