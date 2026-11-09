using UnityEngine;

public class TriggerMonsterState : TriggerConditionBase
{
	public enum monsterType
	{
		[InspectorName("指定关系")]
		selectType,
		[InspectorName("指定ID")]
		selectId
	}

	public enum relatiobShip
	{
		[InspectorName("敌对")]
		ennemyType,
		[InspectorName("友好")]
		frendelyType
	}

	public enum monsterState
	{
		[InspectorName("出生")]
		Spawn,
		[InspectorName("待机")]
		Idle,
		[InspectorName("行动")]
		Action,
		[InspectorName("死亡")]
		Death
	}

	public enum stateType
	{
		[InspectorName("进入")]
		enter,
		[InspectorName("退出")]
		exit
	}

	public monsterType _monsterType;

	public relatiobShip _relatiobShip;

	public int monsterID;

	public monsterState _monsterState;

	public stateType _stateType;

	public override void ToActive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (ushort)0;
			/*Error near IL_0003: ldarga 236 (out-of-bounds)*/;
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	public override void DisableTrigger()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected unsafe void OnActorSateChange(IEvent ievent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_ = 4;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public TriggerMonsterState()
	{
		/*Error: Invalid field token*/;
	}
}
